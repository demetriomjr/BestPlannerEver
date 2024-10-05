namespace models.Entries
{
    public class EntryType
    {
        public int Id { get; set; } = -1;
        public string Name { get; set; } = string.Empty;

        public EntryType()
        {
            
        }

        public EntryType(int id, string name) : base()
        {
            Id = id;
            name = Name;
        }
    }
}
