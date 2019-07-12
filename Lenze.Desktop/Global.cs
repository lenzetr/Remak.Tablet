using Lenze.Desktop.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using Lenze.Desktop.Model;

namespace Lenze.Desktop
{
    public class Global
    {
        public static string AppName { get; set; } = "RemakTablet";
        public static string SystemDrive { get; set; } = Path.GetPathRoot(Environment.SystemDirectory);
        public static string MainSettingDirectory { get; set; } = $"{SystemDrive}{AppName}_Settings\\";
        public static string DatabaseDirectory { get; set; } = Path.Combine(MainSettingDirectory, "Database");

        public static SQLLite Database;

        public static bool FirstInitialize
        {
            get
            {
                var result = false;
                try
                {
                    var databaseValue = Database.GetSettingsValue("FirstInitialize");

                    result = Convert.ToBoolean(databaseValue);
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }

            set => Database.InsertSetting("FirstInitialize", value.ToString());
        }

        public static PlcConfiguration PlcConfiguration { get; set; } = new PlcConfiguration();
        public static bool Command { get; set; }

        public static List<ErrorList> ErrorList { get; set; } = new List<ErrorList>();
        public static BackgroundWorker MainLoadWorker { get; set; }
        public static bool IsDisplayWait { get; set; }
        public static Size Size { get; set; }

        public static void ErrorToDatabase(string module, string name, string message, Exception exc)
        {
            var log = new ErrorList{Module = module, Name = name, Message = message, Exception = exc.ToString()};

            ErrorList.Add(log);
            Database.InsertErrorLog(log);
        }

        public static void ErrorToDatabase(ErrorList list)
        {
            if (list == null) return;
            ErrorList.Add(list);
            Database.InsertErrorLog(list);
        }
    }
}