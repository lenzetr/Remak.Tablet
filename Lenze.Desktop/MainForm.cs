using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Lenze.Desktop.Extensions;
using Lenze.Desktop.Helpers;
using Lenze.Desktop.Services;
using Lenze.Desktop.View;

namespace Lenze.Desktop
{
    public partial class MainForm : Form
    {
        #region Buttons

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this, @"Kapatmak istediğinize eminmisiniz?", "UYARI!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK) Close();
        }

        #endregion

        private void ErrorImage_Click(object sender, EventArgs e)
        {
            var showErrorList = new ErrorListForm();
            showErrorList.ShowDialog();
        }

        #region Initialize

        private readonly BackgroundWorker _worker = new BackgroundWorker();

        public MainForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
#if !DEBUG
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
#endif
            //errorImage.Visible = false;
            Global.Size = Size;
            _worker.DoWork += WorkerOnDoWork;
            Global.MainLoadWorker = _worker;

            var bg = new Background(BgRefresh);
            bg.Initialize(500);
            bg.Start();
        }
        protected override void OnResize(EventArgs e)
        {
#if !DEBUG
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
#endif
            base.OnResize(e);
        }
#endregion

#region Load Function

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!_worker.IsBusy) _worker.RunWorkerAsync();

            var buttons = this.GetAllCtls(typeof(GlassButton)).ToList().Where(item => item.Name != "btnExit");
            foreach (var item in buttons) item.Click += Buttons_Click;
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            try
            {
                var button = (GlassButton) sender;
                ProgessButtonFunction(button);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                Notify.Show(exception.Message, "Hata!", ToolTipIcon.Error);

                Global.ErrorToDatabase("Buttons Click", "Error", exception.Message, exception);
                
            }
        }

#endregion

#region Workers

        private bool[] _actuelButtonsArray;
        private double[] _actuelLrealArray;

        private void BgRefresh()
        {
            try
            {
                if (Global.ErrorList.Count > 0 && Client.ConnectionStatus == false) errorImage.Visible = true;

                if (!Client.ConnectionStatus) return;

                _actuelButtonsArray = Client.GetActValButtonsArray();
                _actuelLrealArray = Client.GetActValLREALArray();

                if (_actuelButtonsArray.Length <= 0 || _actuelLrealArray.Length <= 0) return;
                LoadVariable();

                lbl_Print_OperatorSide_Proxmty.Text = _actuelLrealArray[1].ToString("#.00").Replace(",", ".");
                lbl_Anilox_OperatorSide_Proxmty.Text = _actuelLrealArray[2].ToString("#.00").Replace(",", ".");
                lbl_Print_DriveSide_Proxmty.Text = _actuelLrealArray[3].ToString("#.00").Replace(",", ".");
                lbl_Anilox_DriveSide_Proxmty.Text = _actuelLrealArray[4].ToString("#.00").Replace(",", ".");
                lbl_SideRegisterPosition_Actual.Text = _actuelLrealArray[5].ToString("#.00").Replace(",", ".");
                lbl_LengthRegisterPosition_Actuel.Text = _actuelLrealArray[6].ToString("#.00").Replace(",", ".");

                machineSpeed.Text = GeneralInfo.iMachineSpeed.ToString(CultureInfo.InvariantCulture);
                actuelMeter.Text = GeneralInfo.rMachineCounterMeter.ToString(CultureInfo.InstalledUICulture);

                if (GetActiveButton(_actuelButtonsArray) > 5)
                {
                    lbl_SideRight.Text = "OPERATOR SIDE";
                    lbl_SideLeft.Text = "DRIVE SIDE";
                }
                else
                {
                    lbl_SideLeft.Text = "OPERATOR SIDE";
                    lbl_SideRight.Text = "DRIVE SIDE";
                }
            }
            catch (Exception ex)
            {
                Notify.Show(ex.Message, "Hata!", ToolTipIcon.Error);
                Tools.log.Error("BgRefresh", ex);

                Global.ErrorToDatabase("BgRefresh", "Error", ex.Message, ex);

            }
        }

        private void WorkerOnDoWork(object sender, DoWorkEventArgs doWorkEventArgs)
        {
            const string noConnectionMessage = "PLC bağlantısı kurulamadı Lütfen bağlantınızı kontrol ederek tekar deneyiniz.";
            if (Global.IsDisplayWait) return;

            using (var waitForm = new WaitFormTransparent(delegate
            {

                try
                {
                    Client.UaConnection();
                }
                catch (Exception exception)
                {
                    if (exception.Message == "BadRequestTimeout")
                    {
                        Notify.Show(noConnectionMessage, "Hata!", ToolTipIcon.Error);
                        Global.ErrorToDatabase("Connection", "Connection Error", noConnectionMessage, exception);
                    }
                    else
                    {
                        Notify.Show(exception.Message, "Hata!", ToolTipIcon.Error);
                        Global.ErrorToDatabase("Connection", "Connection Error", exception.Message, exception);
                    }
                }
                finally
                {
                    if (!Client.ConnectionStatus)
                    {
                        Notify.Show(noConnectionMessage,"Dikkat!", ToolTipIcon.Error);
                    }
                }
            }, "PLC bağlanıyor lütfen bekleyiniz...."))
            {
                waitForm.ShowDialog(this);
            }
        }

#endregion

#region Functions

        private static void ProgessButtonFunction(GlassButton selectButton)
        {
            if (selectButton.Variable == null) return;
            Client.SetButtonsValue(selectButton.Variable, true);
            Client.SetButtonsValue(selectButton.Variable, false);

            /*
            switch (selectButton.Name)
            {
                case "switchBtn1":
                    lbl_SideLeft.Text = "OPERATOR SIDE";
                    lbl_SideRight.Text = "DRIVE SIDE";
                    break;
                case "switchBtn2":
                    lbl_SideLeft.Text = "OPERATOR SIDE";
                    lbl_SideRight.Text = "DRIVE SIDE";
                    break;
                case "switchBtn3":
                    lbl_SideLeft.Text = "OPERATOR SIDE";
                    lbl_SideRight.Text = "DRIVE SIDE";
                    break;
                case "switchBtn4":
                    lbl_SideLeft.Text = "OPERATOR SIDE";
                    lbl_SideRight.Text = "DRIVE SIDE";
                    break;
                case "switchBtn5":
                    lbl_SideRight.Text = "OPERATOR SIDE";
                    lbl_SideLeft.Text = "DRIVE SIDE";
                    break;
                case "switchBtn6":
                    lbl_SideRight.Text = "OPERATOR SIDE";
                    lbl_SideLeft.Text = "DRIVE SIDE";
                    break;
                case "switchBtn7":
                    lbl_SideRight.Text = "OPERATOR SIDE";
                    lbl_SideLeft.Text = "DRIVE SIDE";
                    break;
                case "switchBtn8":
                    lbl_SideRight.Text = "OPERATOR SIDE";
                    lbl_SideLeft.Text = "DRIVE SIDE";
                    break;
                default:
                    lbl_SideLeft.Text = "OPERATOR SIDE";
                    lbl_SideRight.Text = "DRIVE SIDE";
                    break;
            }*/
        }

        private void LoadVariable()
        {
            var buttons = this.GetAllCtls(typeof(GlassButton)).ToList();
            if (buttons.Count <= 0) return;
            foreach (var btn in buttons.Where(item => item.GetType() == typeof(GlassButton)).Cast<GlassButton>())
            {
                if (!string.IsNullOrEmpty(btn.Variable))
                {
                    btn.BackColor = Tools.BooleanToColor(_actuelButtonsArray[Convert.ToInt16(btn.Variable)]);
                    btn.ForeColor = Tools.BooleanToTextColor(_actuelButtonsArray[Convert.ToInt16(btn.Variable)]);
                }

                if (btn.Name == "btnExit") btn.Visible = GeneralInfo.xTabletMaintenance;
            }
        }

        private static int GetActiveButton(IReadOnlyList<bool> actuelList)
        {
            var result = 0;
            if (actuelList[30])
                result = 1;
            else if (actuelList[31])
                result = 2;
            else if (actuelList[32])
                result = 3;
            else if (actuelList[33])
                result = 4;
            else if (actuelList[34])
                result = 5;
            else if (actuelList[35])
                result = 6;
            else if (actuelList[36])
                result = 7;
            else if (actuelList[37]) result = 8;

            return result;
        }

#endregion
    }
}