using Lenze.Desktop.Database;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lenze.Desktop
{
    internal class Global
    {
        public static string AppName { get; set; } = "RemakTablet";
        public static string SystemDrive { get; set; } = Path.GetPathRoot(Environment.SystemDirectory);
        public static string MainSettingDirectory { get; set; } = $"{SystemDrive}{Global.AppName}_Settings\\";
        public static string DatabaseDirectory { get; set; } = Path.Combine(MainSettingDirectory, "Database");

        public static SQLLite Database;
        
        public static bool FirstInitialize
        {
            get
            {
                var result = false;
                try
                {
                    var databaseValue = Global.Database.GetSettingsValue("FirstInitialize");

                    result = Convert.ToBoolean(databaseValue);
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }

            set => Global.Database.InsertSetting("FirstInitialize", value.ToString());
        }

        public static PlcConfiguration PlcConfiguration { get; set; } = new PlcConfiguration();
        public static bool Command { get; set; }

        public static List<ErrorList> ErrorList { get; set; } = new List<ErrorList>();

        public static void ErrorToDatabase (string module, string name, string message, Exception exc)
        {
            Global.ErrorList.Add(
                    new ErrorList
                    { Module = module, Name = name, Message = message, Exception = exc.ToString() }
                );

            Database.InsertErrorLog(new ErrorList
            { Module = module, Name = name, Message = message, Exception = exc.ToString() });

        }


    }

    internal class PlcConfiguration
    {
        public string IpAddress
        {
            get
            {
                var result = string.Empty;
                try
                {
                    var databaseValue = Global.Database.GetSettingsValue("IpAddress");

                    result = databaseValue;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }

            set => Global.Database.InsertSetting("IpAddress", value.ToString());
        }

        public string Port
        {
            get
            {
                var result = string.Empty;
                try
                {
                    var databaseValue = Global.Database.GetSettingsValue("Port");

                    result = databaseValue;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }

            set => Global.Database.InsertSetting("Port", value.ToString());
        }
    }

    public class ErrorList
    {
        public string Module { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public DateTime Date { get; set; } = System.DateTime.Now;
    }
}
