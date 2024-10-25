global using LiteDB;
global using models.BankEntries;
global using System.Globalization;
global using System.Text.RegularExpressions;
global using models;

namespace controllers
{
    public static class Controller
    {
        public static BankEntriesController BankEntries = new();
        public static DatabaseController Database = new();
        public static ResourceController Resources = new();
    }
}
