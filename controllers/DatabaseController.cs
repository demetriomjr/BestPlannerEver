namespace controllers
{
    public class DatabaseController
    {
        private static readonly string _filesPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                                                                "BestPlannerEver",
                                                                "databases"
                                                            ),
        _dbFile = Path.Combine(_filesPath, "default_db.db");

        private LiteDatabase Connect()
        {
            if(!Directory.Exists(_filesPath))
                Directory.CreateDirectory(_filesPath);

            return new(new ConnectionString()
            {
                Filename = _dbFile,
                Password = "321",
            });
        }

        public List<T> Load<T>(Func<T, bool>? predicate , out string error) where T : BaseModel
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
        public bool Save<T>(List<T> list, out string error) where T : BaseModel
        {
            error = string.Empty;
            using (var db = Connect())
            {
                if (db.BeginTrans())
                {
                    var result = true;
                    try
                    {
                        foreach(var item in list)
                        {
                            result = Save(db, item, out error);

                            if (!result)
                                return false;
                        }
                        return result;
                    }
                    catch (Exception ex)
                    {
                        error = ex.Message;
                        return false;
                    }
                }
                else
                {
                    error = "An error occurred while trying to begin a transaction in the database.";
                    return false;
                }
            }
        }
        public bool Save<T>(T item, out string error) where T : BaseModel
        {
            try
            {
                error = string.Empty;
                using (var db = Connect())
                    return Save(db, item, out error);
            }
            catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        private bool Save<T>(LiteDatabase db, T item, out string error) where T : BaseModel
        {
            error = string.Empty;
            try
            {
                return db.GetCollection<T>().Upsert(item);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        public bool DeleteItem<T>(Guid id, out string error) where T : BaseModel
        {
            try
            {
                error = string.Empty;
                using (var db = Connect())
                {
                    var item = db.GetCollection<T>().FindById(id);
                    if(item is null || (item as BaseModel)!.IsDeleted)
                    {
                        error = "Item doesn't exists.";
                        return false;
                    }

                    (item as BaseModel)!.IsDeleted = !(item as BaseModel)!.IsDeleted;
                    return db.GetCollection<T>().Upsert(item);
                }
                
            }
            catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
