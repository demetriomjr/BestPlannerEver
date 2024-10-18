using System.ComponentModel.DataAnnotations;

namespace models.BankEntries
{
    public class BankEntry : BaseModel
    {
        public BankEntry()
        {
            
        }
        public BankEntry(DateTime date, int type, string description, decimal value) : base()
        {
            Date = date;
            EntryType = type;
            Description = description;
            Value = value;
        }

        public DateTime? Date { get; set; } = default;
        public int EntryType { get; set; } = 0;
        public int Category { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        public decimal Value { get; set; } = 0.00m;
        public string Observations { get; set; } = string.Empty;
    }
}
