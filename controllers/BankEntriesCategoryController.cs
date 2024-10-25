namespace controllers
{
    public class BankEntriesCategoryController
    {
        public List<EntryCategory> GetList(Func<EntryCategory, bool>? predicate, bool HasAllOptions, out string error)
        {
            try
            {
                error = string.Empty;
                var list = Controller.Database.Load(predicate, out error);

                if(HasAllOptions)
                    list.Insert(0, new EntryCategory(Guid.Empty, "Todas"));
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
