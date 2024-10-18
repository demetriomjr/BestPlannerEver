using models.BankEntries;
using System.Globalization;
using System.Text.RegularExpressions;

namespace controllers
{
    public class BankEntriesController
    {
        private static readonly string[] dateFormats = new[] { "d MMM yyyy", "dd MMM yyyy" };
        private static readonly Regex EntryTypeRegex = new Regex(@"\d+,\d{2}\s([DC])");
        private static readonly Dictionary<string, Func<string, string>> DecimalValuePatterns = new()
        {
            {@"\b\d+\,\d{2}\b", value => value.Replace(",", ".")},
            {@"\b\d+\.\d{2}\b", value => value.Replace(",", ".")},
            {@"\b\d+\.\d{3}\.\d{2}\b", value =>
                {
                    string decimalValue = Regex.Replace(value, @"[^0-9]+", "");
                    decimalValue = decimalValue.Insert(decimalValue.Length - 2, ".");
                    return decimalValue;
                }
            },
            {@"\b\d+\.\d{3}\,\d{2}\b", value =>
                {
                    string decimalValue = Regex.Replace(value, @"[^0-9]+", "");
                    decimalValue = decimalValue.Insert(decimalValue.Length - 2, ".");
                    return decimalValue;
                }
            },
            {@"\b\d+\.\d{3}\,\d{1}\b", value =>
                {
                    string decimalValue = $"{Regex.Replace(value, @"[^0-9]+", "")}0";
                    decimalValue = decimalValue.Insert(decimalValue.Length - 2, ".");
                    return decimalValue;
                }
            },
            {@"\b\d+\.\d{3}\.\d{1}\b", value =>
                {
                    string decimalValue = $"{Regex.Replace(value, @"[^0-9]+", "")}0";
                    decimalValue = decimalValue.Insert(decimalValue.Length - 2, ".");
                    return decimalValue;
                }
            },
            {@"\b\d+\,\d{1}\b", value =>
                {
                    string decimalValue = $"{Regex.Replace(value, @"[^0-9]+", "")}0";
                    decimalValue = decimalValue.Insert(decimalValue.Length - 2, ".");
                    return decimalValue;
                }
            },
            {@"\b\d+\.\d{1}\b", value =>
                {
                    string decimalValue = $"{Regex.Replace(value, @"[^0-9]+", "")}0";
                    decimalValue = decimalValue.Insert(decimalValue.Length - 2, ".");
                    return decimalValue;
                }
            },
            {@"\b\d+\b", value =>
                {
                    string decimalValue = $"{Regex.Replace(value, @"[^0-9]+", "")}00";
                    decimalValue = decimalValue.Insert(decimalValue.Length - 2, ".");
                    return decimalValue;
                }
            },
        };
        private static readonly Dictionary<string, Func<string, DateTime?>> DatePatterns = new()
        {
            {
                @"\b\d{2}/\d{2}/\d{4}\b", // DD/MM/YYYY
                date => DateTime.TryParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedDate)
                        ? parsedDate : (DateTime?)null
            },
            {
                @"\b\d{1,2}\s(?:jan|fev|mar|abr|mai|jun|jul|ago|set|out|nov|dez)\b", // (D)D MMM
                date => DateTime.TryParseExact($"{date} {DateTime.Today.Year}", dateFormats, CultureInfo.CurrentCulture,
                                                         DateTimeStyles.None, out var parsedDate)
                        ? parsedDate : (DateTime?)null
            }
        };
        private static readonly (string, string)[] StringCorrections =
        [
            ( " - ", " - " ),
            ( " 000000000000", string.Empty ),
        ];

        public BankEntriesCategoryController Categories = new();
        public BankEntriesResourceController Resources = new();

        public List<BankEntry> GetList(Func<BankEntry, bool>? predicate, out string error)
        {
            try
            {
                var result =  Controller.Database.Load(predicate, out error);
                return result;
            }
            catch(Exception ex) 
            {
                error = ex.Message;
                return new()!;
            }
        }
        public bool Validate(BankEntry entry, out string error) 
        {
            error = "";
            return true;
        }
        public bool Save(BankEntry entry, out string error)
        {
            try
            {
                var result = Controller.Database.Save(entry, out error);
                return result;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        public bool DeleteItem(Guid id, out string error)
        {
            try
            {
                var result = Controller.Database.DeleteItem<BankEntry>(id, out error);
                return result;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        public List<BankEntry> TryConvertFromText(string input, out string error)
        {
            try
            {
                error = string.Empty;
                var list = new List<BankEntry>();
                var lines = Regex.Split(input, @"\r?\n")
                                 .Where(x => !string.IsNullOrWhiteSpace(x))
                                 .ToArray();

                foreach (var line in lines)
                {
                    if (line.Length <= 2)
                        continue;

                    string formattedLine = line;

                    foreach (var correction in StringCorrections)
                        formattedLine = formattedLine.Replace(correction.Item1, correction.Item2);

                    if (formattedLine.Length <= 2)
                        continue;

                    DateTime currentDate = DateTime.Today;
                    string currentDesc = formattedLine;
                    decimal currentValue = 0.0m;
                    int currentType = 1, valueIndex = 0;

                    foreach (var pattern in DatePatterns)
                    {
                        var match = Regex.Match(formattedLine, pattern.Key, RegexOptions.IgnoreCase);
                        if (match.Success)
                        {
                            var tempDate = pattern.Value(match.Value);
                            if (tempDate.HasValue)
                            {
                                currentDate = tempDate.Value;
                                currentDesc = currentDesc.Replace(match.Value, string.Empty);
                            }
                            break;
                        }
                    }

                    foreach (var pattern in DecimalValuePatterns)
                    {
                        var match = Regex.Match(formattedLine, pattern.Key);
                        if (match.Success)
                        {
                            string convertedValue = pattern.Value(match.Value);
                            valueIndex = formattedLine.IndexOf(convertedValue);
                            currentValue = Convert.ToDecimal(convertedValue, CultureInfo.InvariantCulture);
                            currentDesc = currentDesc.Replace(match.Value, string.Empty);
                            break;
                        }
                    }

                    var typeMatch = EntryTypeRegex.Match(formattedLine.Substring(valueIndex));

                    if (typeMatch.Success)
                    {
                        var sign = typeMatch.Groups[1].Value[0];
                        currentType = sign.Equals('D') ? 2 : sign.Equals('C') ? 1 : 0;
                    }
                    else continue;

                    currentDesc = currentDesc.Trim();
                    currentDesc = Regex.Replace(currentDesc, @"\s+", " ");
                    if (string.IsNullOrWhiteSpace(currentDesc))
                        currentDesc = "S/D";

                    list.Add(new(currentDate, currentType, currentDesc, currentValue));
                }

                return list;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null!;
            }
        }
    }
}
