namespace controllers
{
    public class DatabaseController
    {
        private static readonly string _dbFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                                                                "BestPlannerEver",
                                                                "databases",
                                                                "default_db.db"
                                                            );
        private LiteDatabase Connect()
        {
            return new(new ConnectionString()
            {
                Filename = _dbFile,
                Password = "321",
            });
        }

        public List<T> Load<T>(Func<T, bool>? predicate , out string error) where T : class
        {
            try
            {
                error = string.Empty;
                using (var db = Connect())
                    if (predicate is null)
                        return db.GetCollection<T>().FindAll().ToList();
                    else return db.GetCollection<T>().Find(x => predicate(x)).ToList();
                
            }
            catch(Exception ex)
            {
                error = ex.Message;
                return new()!;
            }
        }

        public bool Save<T>(T item, out string error) where T : class
        {
            try
            {
                error = string.Empty;
                using (var db = Connect())        
                    return db.GetCollection<T>().Upsert(item);
            }
            catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public bool DeleteItem<T>(Guid id, out string error)
        {
            try
            {
                error = string.Empty;
                using (var db = Connect())
                    return db.GetCollection<T>().Delete(id);
                
            }
            catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
