namespace models.BankEntries
{
    public class EntryCategory : BaseModel
    {
        public string Name { get; set; } = string.Empty;

        public EntryCategory()
        {

        }

        public EntryCategory(int id, string name) : base()
        {
            Name = name;
            Id = id;
        }
    }
}
