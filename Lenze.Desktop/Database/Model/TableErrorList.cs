using System.Data.SQLite;

namespace Lenze.Desktop.Database.Model
{
    internal class TableErrorList
    {
        public static string TableName { get; private set; } = "ErrorList";
        public static SQLiteTable Build()
        {
            var table = new SQLiteTable(TableName);
            table.Columns.Add(new SQLiteColumn("id", true));
            table.Columns.Add(new SQLiteColumn("Module"));
            table.Columns.Add(new SQLiteColumn("Name"));
            table.Columns.Add(new SQLiteColumn("Message"));
            table.Columns.Add(new SQLiteColumn("Exception"));
            table.Columns.Add(new SQLiteColumn("Date", ColType.DateTime));

            return table;
        }
    }
}
