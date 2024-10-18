namespace models.BankEntries
{
    public class EntryCategory
    {
        public int Id { get; set; } = -1;
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
