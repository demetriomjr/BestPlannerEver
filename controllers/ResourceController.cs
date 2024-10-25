namespace controllers
{
    public class ResourceController
    {
        public List<EntryType> EntryTypes(bool AllOption = false)
        {
            var result = new List<EntryType>()
            {
                new(1, "Entrada"),
                new(2, "Saída"),
            };

            if (AllOption)
                result.Insert(0, new(0, "Todos"));

            return result;
        }
    }
}
