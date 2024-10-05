namespace controllers
{
    public class RecordsCategoryController
    {
        public List<EntryCategory> GetList(Func<EntryCategory, bool>? predicate, bool AllOption, out string error)
        {
            try
            {
                error = string.Empty;
                var list = Controller.Database.Load(predicate, out error);

                if(AllOption)
                    list.Insert(0, new EntryCategory(0, "Todas"));
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
