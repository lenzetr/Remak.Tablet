using System.Data.SQLite;
using Lenze.Desktop.Database.Model;

namespace Lenze.Desktop.Database
{
    internal class Helper
    {
        public static void CheckDatabaseTable()
        {
            if (!Global.Database.CheckTable(TableSettings.TableName))
            {
                 Global.Database.CreateTable(TableSettings.Build());
            }

            if (!Global.Database.CheckTable(TableErrorList.TableName))
            {
                Global.Database.CreateTable(TableErrorList.Build());
            }
        }
    }
}