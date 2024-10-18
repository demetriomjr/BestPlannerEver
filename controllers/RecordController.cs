namespace controllers
{
    public class RecordController
    {

        public RecordsCategoryController Categories = new();
        public List<Entry> GetList(Func<Entry, bool>? predicate, out string error)
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

        public bool Validate(Entry entry, out string error) 
        {
            error = "";
            return true;
        }

        public bool Save(Entry entry, out string error)
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
                var result = Controller.Database.DeleteItem<Entry>(id, out error);
                return result;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
