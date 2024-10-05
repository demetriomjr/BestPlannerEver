global using LiteDB;
global using models.Entries;

namespace controllers
{
    public static class Controller
    {
        public static RecordController Records = new();
        public static DatabaseController Database = new();
        public static ResourceController Resources = new();
    }
}
