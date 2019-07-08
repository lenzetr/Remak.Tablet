using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace Lenze.Desktop.Helpers
{
    public class Tools
    {
        public string AppName { get; set; } = System.Diagnostics.Process.GetCurrentProcess().ProcessName;

        public static string ProcessName { get; private set; } = Process.GetCurrentProcess().ProcessName;
        public static IniFile SettingIni = new IniFile("settings.ini");

        public static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        internal static Color BooleanToColor(bool val)
        {
            return val ? Color.DodgerBlue : Color.Snow;
        }

        internal static Color BooleanToTextColor(bool val)
        {
            return val ? Color.White : Color.Black;
        }

        public static bool PingHost(string nameOrAddress)
        {
            var pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                var reply = pinger.Send(nameOrAddress);
                if (reply != null) pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            catch (Exception)
            {
                //
            }
            finally
            {
                pinger?.Dispose();
            }

            return pingable;
        }

        public static void CheckDatabaseStartup()
        {
            if (Directory.Exists(Global.MainSettingDirectory)) return;
            var di = Directory.CreateDirectory(Global.MainSettingDirectory);
            di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;

            if (!Directory.Exists(Global.DatabaseDirectory))
            {
                Directory.CreateDirectory(Global.DatabaseDirectory);
            }
        }
    }
}