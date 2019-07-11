using System.Data.SQLite;

namespace Lenze.Desktop.Database.Model
{
    internal class TableSettings
    {
        public static string TableName { get; private set; } = "Settings";

        public static SQLiteTable Build()
        {
            var table = new SQLiteTable(TableName);
            table.Columns.Add(new SQLiteColumn("id", true));
            table.Columns.Add(new SQLiteColumn("name"));
            table.Columns.Add(new SQLiteColumn("value"));
            table.Columns.Add(new SQLiteColumn("status", ColType.Integer));

            return table;
        }
    }
}
