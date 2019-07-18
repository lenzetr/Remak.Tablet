using System.Data.SQLite;
using Remak.Tablet.UI.Database.Model;

namespace Remak.Tablet.UI.Database
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