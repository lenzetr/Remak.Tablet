using System;
using System.Windows.Forms;

namespace Lenze.Desktop.Helpers
{
    internal class Notify
    {
        public static void Show(string message, string title, ToolTipIcon icon, EventHandler clickHandler = null)
        {
            var notification = new NotifyIcon()
            {
                Visible = true,
                Icon = System.Drawing.SystemIcons.Information,
                BalloonTipIcon = icon,
                BalloonTipTitle = title,
                BalloonTipText = message,
            };

            //notification.BalloonTipClicked += clickHandler;
            notification.BalloonTipClosed += clickHandler;
            notification.Click += clickHandler;
            notification.BalloonTipClicked += Notification_BalloonTipClicked;
            notification.ShowBalloonTip(500);
        }

        private static void Notification_BalloonTipClicked(object sender, EventArgs e)
        {
            var a = (NotifyIcon) sender;
            a.Dispose();
        }

        public static void Show(string message)
        {
            Show(message, Tools.ProcessName, ToolTipIcon.Info);
        }

        public static void Show(string message, string title)
        {
            Show(message, title, ToolTipIcon.Info);
        }

        private static void Dispose(NotifyIcon notifyIcon)
        {
            notifyIcon.Dispose();
        }
    }
}
