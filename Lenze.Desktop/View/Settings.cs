using System;
using System.Windows.Forms;
using Lenze.Desktop.Database;
using Lenze.Desktop.Helpers;

namespace Lenze.Desktop.View
{
    public partial class Settings : Form
    {
        public bool FirstInitialize { get; set; }
        public Settings()
        {
            InitializeComponent();
            TopMost = true;

            if (!Global.Command) return;
            Tools.CheckDatabaseStartup();
            Global.Database = new SQLLite();
        }

        private void IpAddress_MouseUp(object sender, MouseEventArgs e)
        {
            var numm = new NumericKeypad();
            var dialog = numm.ShowDialog();
            if (dialog == DialogResult.OK) IpAddress.Text = numm.Data;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        public bool SetStatus { get; set; } = false;
        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (!Tools.PingHost(IpAddress.Text))
            {
                Notify.Show("Yazmış olduğunuz Ip adresine ulaşılamıyor lütfen Ip adresini kontrol ediniz.",
                    "Bağlantı Hatası", ToolTipIcon.Error);
            }
            else
            {
                try
                {
                    Global.PlcConfiguration.IpAddress = IpAddress.Text;
                    Global.PlcConfiguration.Port = "4840";

                    if (FirstInitialize)
                    {
                        Global.FirstInitialize = true;
                    }

                    SetStatus = true;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    Notify.Show(exception.Message, "Hata!", ToolTipIcon.Error);
                    throw;
                }
                finally
                {
                    if (SetStatus)
                    {
                        DialogResult = DialogResult.OK;
                        TopMost = false;
                        
                        if (Global.Command)
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Close();
                        }
                    }
                }
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            TopMost = false;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            IpAddress.Text = string.IsNullOrEmpty(Global.PlcConfiguration.IpAddress) ? "192.168.5.99" : Global.PlcConfiguration.IpAddress;
        }
    }
}