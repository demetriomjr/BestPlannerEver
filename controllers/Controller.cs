global using LiteDB;

namespace controllers
{
    public static class Controller
    {
        public static BankEntriesController BankEntries = new();
        public static DatabaseController Database = new();
    }
}
