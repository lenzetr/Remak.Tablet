using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Remak.Tablet.UI.Helpers;
using Remak.Tablet.UI.View;

namespace Remak.Tablet.UI
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ApplicationThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            try
            {
                if (args.Length > 0)
                {
                    var command = args[0];

                    if (command == "/settings")
                    {
                        Global.ApplicationStartupCommand = true;
                        Application.Run(new Settings());
                    }
                }
                else
                {
                    var myContext = new SplashApplicationContext(new MainForm(), new SplashForm(), 0);
                    Application.Run(myContext);
                }
            }
            catch (Exception e)
            {
                HandleException(e);
            }

            Environment.Exit(-1);
        }

        /// <summary>
        ///     Global exceptions in Non User Interfarce(other thread) antipicated error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException((Exception) e.ExceptionObject);
        }

        /// <summary>
        ///     Global exceptions in User Interfarce antipicated error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            HandleException(e.Exception);
        }

        internal static void HandleException(Exception ex)
        {
            var LF = Environment.NewLine + Environment.NewLine;
            var title = $"Oups... I got a crash at {DateTime.Now}";
            var infos = "Please take a screenshot of this message\n\r\n\r" +
                        $"Message : {LF}{ex.Message}{LF}" +
                        $"Source : {LF}{ex.Source}{LF}" +
                        $"Stack : {LF}{ex.StackTrace}{LF}" +
                        $"InnerException : {ex.InnerException}";

            Global.ErrorToDatabase(title, "Main Application Error", infos, ex);

            MessageBox.Show(infos, title, MessageBoxButtons.OK, MessageBoxIcon.Error); // Do logging of exception details

            Environment.Exit(0);
        }
    }
}