namespace models.BankEntries
{
    public class BankEntry : BaseModel
    {
        public BankEntry()
        {
            
        }
        public BankEntry(DateTime date, int type, string description, decimal value) : base()
        {
            EntryDate = date;
            EntryType = type;
            Description = description;
            CurrencyValue = value;
        }

        public DateTime? EntryDate { get; set; } = default;
        public int EntryType { get; set; } = 0;
        public int Category { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        public decimal CurrencyValue { get; set; } = 0.00m;
        public string Observations { get; set; } = string.Empty;
    }
}
