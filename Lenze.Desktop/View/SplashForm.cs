using Lenze.Desktop.Database;
using Lenze.Desktop.Helpers;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Lenze.Desktop.Model;

namespace Lenze.Desktop.View
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();

            progressBar1.Maximum = 100;
            progressBar1.Step = 30;
            TopMost = true;
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            #region Start
            // Show Form
            Show();
            Application.DoEvents(); // Finish Paint
            Cursor.Current = Cursors.WaitCursor;
            progressBar1.PerformStep();
            progressBar1.Value = 10;
            // Simulate some activity (e.g. connect to database, caching data, retrieving defaults)
            #endregion

            #region Step 1
            labelStatus.Text = "Veritabanı Kontrol Ediliyor...";
            labelStatus.Refresh();
            Tools.CheckDatabaseStartup();
            Global.Database = new SQLLite();
            progressBar1.Value = 30;
            Thread.Sleep(1000);
            #endregion

            #region Step 2

            labelStatus.Text = "Ayarlar Kontrol Ediliyor...";
            labelStatus.Refresh();

            if (!Global.FirstInitialize)
            {
                var settingForm = new Settings { FirstInitialize = true };
                var returnDialog = settingForm.ShowDialog();

                if (returnDialog == DialogResult.OK)
                {

                }
            }

            progressBar1.Value = 60;
            Thread.Sleep(1000);

            #endregion

            #region Step 3
            labelStatus.Text = "PLC Bağlantısı Kontrol Ediliyor...";
            labelStatus.Refresh();

            if (!Tools.PingHost(Global.PlcConfiguration.IpAddress))
            {
                Notify.Show("PLC IP adresine ulaşılamıyor lütfen girmiş olduğunuz IP adresini ve PLC'nin çalışır durumda olduğunu kontrol ediniz.",
                    "Bağlantı Hatası", ToolTipIcon.Error);

                Global.ErrorToDatabase(
                    new ErrorList { Module = "Startup Test", Name = "Connection Error", Message = "PLC IP adresine ulaşılamıyor lütfen girmiş olduğunuz IP adresini ve PLC'nin çalışır durumda olduğunu kontrol ediniz.", Exception = "" }
                );

                //Environment.Exit(0);
            }

            progressBar1.Value = 90;
            Thread.Sleep(1000);

            #endregion

            #region End
            progressBar1.Value = 100;

            TopMost = false;
            Close();
            #endregion
        }

        private void SplashForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TopMost = false;
        }

    }
}