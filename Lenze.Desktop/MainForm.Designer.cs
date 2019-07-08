using System;

namespace Lenze.Desktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbl_SideLeft = new System.Windows.Forms.Label();
            this.lbl_SideRight = new System.Windows.Forms.Label();
            this.lbl_Print_OperatorSide_Proxmty = new System.Windows.Forms.Label();
            this.lbl_Anilox_OperatorSide_Proxmty = new System.Windows.Forms.Label();
            this.lbl_Anilox_DriveSide_Proxmty = new System.Windows.Forms.Label();
            this.lbl_Print_DriveSide_Proxmty = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_LengthRegisterPosition_Actuel = new System.Windows.Forms.Label();
            this.lbl_SideRegisterPosition_Actual = new System.Windows.Forms.Label();
            this.lbl_LengthRegisterPosition = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.actuelMeter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.machineSpeed = new System.Windows.Forms.Label();
            this.errorImage = new System.Windows.Forms.PictureBox();
            this.switchBtn1 = new Lenze.Desktop.GlassButton();
            this.switchBtn2 = new Lenze.Desktop.GlassButton();
            this.switchBtn3 = new Lenze.Desktop.GlassButton();
            this.switchBtn4 = new Lenze.Desktop.GlassButton();
            this.switchBtn5 = new Lenze.Desktop.GlassButton();
            this.switchBtn6 = new Lenze.Desktop.GlassButton();
            this.switchBtn7 = new Lenze.Desktop.GlassButton();
            this.switchBtn8 = new Lenze.Desktop.GlassButton();
            this.btnLengthRegisterDown_Right = new Lenze.Desktop.GlassButton();
            this.btnSideRegister_Right = new Lenze.Desktop.GlassButton();
            this.btnLengthRegisterUp_Right = new Lenze.Desktop.GlassButton();
            this.btnLengthRegisterDown_Left = new Lenze.Desktop.GlassButton();
            this.btnSideRegister_Left = new Lenze.Desktop.GlassButton();
            this.btnLengthRegisterUp_left = new Lenze.Desktop.GlassButton();
            this.btnRightLeft = new Lenze.Desktop.GlassButton();
            this.btnPrintOFF = new Lenze.Desktop.GlassButton();
            this.btnLeftRight = new Lenze.Desktop.GlassButton();
            this.btnCont_Run = new Lenze.Desktop.GlassButton();
            this.btnON_OFF = new Lenze.Desktop.GlassButton();
            this.btnSeperate = new Lenze.Desktop.GlassButton();
            this.btn0_01mm = new Lenze.Desktop.GlassButton();
            this.btn0_1mm = new Lenze.Desktop.GlassButton();
            this.btn1mm = new Lenze.Desktop.GlassButton();
            this.btnAniloxOUT_Right = new Lenze.Desktop.GlassButton();
            this.btnAniloxIN_Right = new Lenze.Desktop.GlassButton();
            this.btnPrintOUT_Right = new Lenze.Desktop.GlassButton();
            this.btnPrintIN_Right = new Lenze.Desktop.GlassButton();
            this.btnAniloxOUT_Left = new Lenze.Desktop.GlassButton();
            this.btnAniloxIN_Left = new Lenze.Desktop.GlassButton();
            this.btnPrintOUT_Left = new Lenze.Desktop.GlassButton();
            this.btnPrintIN_Left = new Lenze.Desktop.GlassButton();
            this.btnExit = new Lenze.Desktop.GlassButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SideLeft
            // 
            this.lbl_SideLeft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_SideLeft.AutoSize = true;
            this.lbl_SideLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SideLeft.Location = new System.Drawing.Point(199, 156);
            this.lbl_SideLeft.Name = "lbl_SideLeft";
            this.lbl_SideLeft.Size = new System.Drawing.Size(238, 31);
            this.lbl_SideLeft.TabIndex = 30;
            this.lbl_SideLeft.Text = "OPERATOR SIDE";
            // 
            // lbl_SideRight
            // 
            this.lbl_SideRight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_SideRight.AutoSize = true;
            this.lbl_SideRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SideRight.Location = new System.Drawing.Point(835, 156);
            this.lbl_SideRight.Name = "lbl_SideRight";
            this.lbl_SideRight.Size = new System.Drawing.Size(169, 31);
            this.lbl_SideRight.TabIndex = 31;
            this.lbl_SideRight.Text = "DRIVE SIDE";
            // 
            // lbl_Print_OperatorSide_Proxmty
            // 
            this.lbl_Print_OperatorSide_Proxmty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Print_OperatorSide_Proxmty.AutoSize = true;
            this.lbl_Print_OperatorSide_Proxmty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Print_OperatorSide_Proxmty.Location = new System.Drawing.Point(379, 362);
            this.lbl_Print_OperatorSide_Proxmty.Name = "lbl_Print_OperatorSide_Proxmty";
            this.lbl_Print_OperatorSide_Proxmty.Size = new System.Drawing.Size(82, 31);
            this.lbl_Print_OperatorSide_Proxmty.TabIndex = 32;
            this.lbl_Print_OperatorSide_Proxmty.Text = "00.00";
            // 
            // lbl_Anilox_OperatorSide_Proxmty
            // 
            this.lbl_Anilox_OperatorSide_Proxmty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Anilox_OperatorSide_Proxmty.AutoSize = true;
            this.lbl_Anilox_OperatorSide_Proxmty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Anilox_OperatorSide_Proxmty.Location = new System.Drawing.Point(380, 498);
            this.lbl_Anilox_OperatorSide_Proxmty.Name = "lbl_Anilox_OperatorSide_Proxmty";
            this.lbl_Anilox_OperatorSide_Proxmty.Size = new System.Drawing.Size(82, 31);
            this.lbl_Anilox_OperatorSide_Proxmty.TabIndex = 33;
            this.lbl_Anilox_OperatorSide_Proxmty.Text = "00.00";
            // 
            // lbl_Anilox_DriveSide_Proxmty
            // 
            this.lbl_Anilox_DriveSide_Proxmty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Anilox_DriveSide_Proxmty.AutoSize = true;
            this.lbl_Anilox_DriveSide_Proxmty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Anilox_DriveSide_Proxmty.Location = new System.Drawing.Point(777, 498);
            this.lbl_Anilox_DriveSide_Proxmty.Name = "lbl_Anilox_DriveSide_Proxmty";
            this.lbl_Anilox_DriveSide_Proxmty.Size = new System.Drawing.Size(82, 31);
            this.lbl_Anilox_DriveSide_Proxmty.TabIndex = 35;
            this.lbl_Anilox_DriveSide_Proxmty.Text = "00.00";
            // 
            // lbl_Print_DriveSide_Proxmty
            // 
            this.lbl_Print_DriveSide_Proxmty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Print_DriveSide_Proxmty.AutoSize = true;
            this.lbl_Print_DriveSide_Proxmty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Print_DriveSide_Proxmty.Location = new System.Drawing.Point(776, 362);
            this.lbl_Print_DriveSide_Proxmty.Name = "lbl_Print_DriveSide_Proxmty";
            this.lbl_Print_DriveSide_Proxmty.Size = new System.Drawing.Size(82, 31);
            this.lbl_Print_DriveSide_Proxmty.TabIndex = 34;
            this.lbl_Print_DriveSide_Proxmty.Text = "00.00";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbl_LengthRegisterPosition_Actuel);
            this.panel1.Controls.Add(this.lbl_SideRegisterPosition_Actual);
            this.panel1.Controls.Add(this.lbl_LengthRegisterPosition);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(483, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 88);
            this.panel1.TabIndex = 36;
            // 
            // lbl_LengthRegisterPosition_Actuel
            // 
            this.lbl_LengthRegisterPosition_Actuel.AutoSize = true;
            this.lbl_LengthRegisterPosition_Actuel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LengthRegisterPosition_Actuel.Location = new System.Drawing.Point(137, 56);
            this.lbl_LengthRegisterPosition_Actuel.Name = "lbl_LengthRegisterPosition_Actuel";
            this.lbl_LengthRegisterPosition_Actuel.Size = new System.Drawing.Size(40, 20);
            this.lbl_LengthRegisterPosition_Actuel.TabIndex = 38;
            this.lbl_LengthRegisterPosition_Actuel.Text = "0.000";
            // 
            // lbl_SideRegisterPosition_Actual
            // 
            this.lbl_SideRegisterPosition_Actual.AutoSize = true;
            this.lbl_SideRegisterPosition_Actual.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SideRegisterPosition_Actual.Location = new System.Drawing.Point(137, 33);
            this.lbl_SideRegisterPosition_Actual.Name = "lbl_SideRegisterPosition_Actual";
            this.lbl_SideRegisterPosition_Actual.Size = new System.Drawing.Size(40, 20);
            this.lbl_SideRegisterPosition_Actual.TabIndex = 37;
            this.lbl_SideRegisterPosition_Actual.Text = "00.00";
            // 
            // lbl_LengthRegisterPosition
            // 
            this.lbl_LengthRegisterPosition.AutoSize = true;
            this.lbl_LengthRegisterPosition.Location = new System.Drawing.Point(3, 61);
            this.lbl_LengthRegisterPosition.Name = "lbl_LengthRegisterPosition";
            this.lbl_LengthRegisterPosition.Size = new System.Drawing.Size(128, 13);
            this.lbl_LengthRegisterPosition.TabIndex = 2;
            this.lbl_LengthRegisterPosition.Text = "Length Register Position :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Side Register Position :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Print Cylinder";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(483, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 59);
            this.panel2.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(92, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "Anilox Cylinder";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.groupBoxInfo);
            this.panel3.Location = new System.Drawing.Point(265, 564);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 101);
            this.panel3.TabIndex = 42;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.label3);
            this.groupBoxInfo.Controls.Add(this.actuelMeter);
            this.groupBoxInfo.Controls.Add(this.label2);
            this.groupBoxInfo.Controls.Add(this.machineSpeed);
            this.groupBoxInfo.Location = new System.Drawing.Point(24, 14);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(665, 68);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Info";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(359, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Actuel Meter :";
            // 
            // actuelMeter
            // 
            this.actuelMeter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.actuelMeter.AutoSize = true;
            this.actuelMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.actuelMeter.Location = new System.Drawing.Point(537, 22);
            this.actuelMeter.Name = "actuelMeter";
            this.actuelMeter.Size = new System.Drawing.Size(66, 25);
            this.actuelMeter.TabIndex = 44;
            this.actuelMeter.Text = "00.00";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Machine Speed :";
            // 
            // machineSpeed
            // 
            this.machineSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.machineSpeed.AutoSize = true;
            this.machineSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.machineSpeed.Location = new System.Drawing.Point(195, 22);
            this.machineSpeed.Name = "machineSpeed";
            this.machineSpeed.Size = new System.Drawing.Size(66, 25);
            this.machineSpeed.TabIndex = 34;
            this.machineSpeed.Text = "00.00";
            // 
            // errorImage
            // 
            this.errorImage.Image = global::Lenze.Desktop.Properties.Resources.uyari;
            this.errorImage.Location = new System.Drawing.Point(26, 368);
            this.errorImage.Name = "errorImage";
            this.errorImage.Size = new System.Drawing.Size(137, 119);
            this.errorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorImage.TabIndex = 43;
            this.errorImage.TabStop = false;
            this.errorImage.Click += new System.EventHandler(this.ErrorImage_Click);
            // 
            // switchBtn1
            // 
            this.switchBtn1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.switchBtn1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.switchBtn1.FontAntiAlias = true;
            this.switchBtn1.ForeColor = System.Drawing.Color.Black;
            this.switchBtn1.Location = new System.Drawing.Point(81, 12);
            this.switchBtn1.Name = "switchBtn1";
            this.switchBtn1.RoundedCornerRadius = 6;
            this.switchBtn1.Size = new System.Drawing.Size(134, 70);
            this.switchBtn1.TabIndex = 1;
            this.switchBtn1.Tag = "";
            this.switchBtn1.Text = "1";
            this.switchBtn1.UseVisualStyleBackColor = true;
            this.switchBtn1.Variable = "30";
            // 
            // switchBtn2
            // 
            this.switchBtn2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.switchBtn2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.switchBtn2.FontAntiAlias = true;
            this.switchBtn2.ForeColor = System.Drawing.Color.Black;
            this.switchBtn2.Location = new System.Drawing.Point(221, 12);
            this.switchBtn2.Name = "switchBtn2";
            this.switchBtn2.RoundedCornerRadius = 6;
            this.switchBtn2.Size = new System.Drawing.Size(134, 70);
            this.switchBtn2.TabIndex = 2;
            this.switchBtn2.Text = "2";
            this.switchBtn2.UseVisualStyleBackColor = true;
            this.switchBtn2.Variable = "31";
            // 
            // switchBtn3
            // 
            this.switchBtn3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.switchBtn3.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.switchBtn3.FontAntiAlias = true;
            this.switchBtn3.ForeColor = System.Drawing.Color.Black;
            this.switchBtn3.Location = new System.Drawing.Point(361, 12);
            this.switchBtn3.Name = "switchBtn3";
            this.switchBtn3.RoundedCornerRadius = 6;
            this.switchBtn3.Size = new System.Drawing.Size(134, 70);
            this.switchBtn3.TabIndex = 3;
            this.switchBtn3.Text = "3";
            this.switchBtn3.UseVisualStyleBackColor = true;
            this.switchBtn3.Variable = "32";
            // 
            // switchBtn4
            // 
            this.switchBtn4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.switchBtn4.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.switchBtn4.FontAntiAlias = true;
            this.switchBtn4.ForeColor = System.Drawing.Color.Black;
            this.switchBtn4.Location = new System.Drawing.Point(501, 12);
            this.switchBtn4.Name = "switchBtn4";
            this.switchBtn4.RoundedCornerRadius = 6;
            this.switchBtn4.Size = new System.Drawing.Size(134, 70);
            this.switchBtn4.TabIndex = 4;
            this.switchBtn4.Text = "4";
            this.switchBtn4.UseVisualStyleBackColor = true;
            this.switchBtn4.Variable = "33";
            // 
            // switchBtn5
            // 
            this.switchBtn5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.switchBtn5.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.switchBtn5.FontAntiAlias = true;
            this.switchBtn5.ForeColor = System.Drawing.Color.Black;
            this.switchBtn5.Location = new System.Drawing.Point(641, 12);
            this.switchBtn5.Name = "switchBtn5";
            this.switchBtn5.RoundedCornerRadius = 6;
            this.switchBtn5.Size = new System.Drawing.Size(134, 70);
            this.switchBtn5.TabIndex = 5;
            this.switchBtn5.Text = "5";
            this.switchBtn5.UseVisualStyleBackColor = true;
            this.switchBtn5.Variable = "34";
            // 
            // switchBtn6
            // 
            this.switchBtn6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.switchBtn6.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.switchBtn6.FontAntiAlias = true;
            this.switchBtn6.ForeColor = System.Drawing.Color.Black;
            this.switchBtn6.Location = new System.Drawing.Point(781, 12);
            this.switchBtn6.Name = "switchBtn6";
            this.switchBtn6.RoundedCornerRadius = 6;
            this.switchBtn6.Size = new System.Drawing.Size(134, 70);
            this.switchBtn6.TabIndex = 6;
            this.switchBtn6.Text = "6";
            this.switchBtn6.UseVisualStyleBackColor = true;
            this.switchBtn6.Variable = "35";
            // 
            // switchBtn7
            // 
            this.switchBtn7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.switchBtn7.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.switchBtn7.FontAntiAlias = true;
            this.switchBtn7.ForeColor = System.Drawing.Color.Black;
            this.switchBtn7.Location = new System.Drawing.Point(921, 12);
            this.switchBtn7.Name = "switchBtn7";
            this.switchBtn7.RoundedCornerRadius = 7;
            this.switchBtn7.Size = new System.Drawing.Size(134, 70);
            this.switchBtn7.TabIndex = 40;
            this.switchBtn7.Text = "7";
            this.switchBtn7.UseVisualStyleBackColor = true;
            this.switchBtn7.Variable = "36";
            // 
            // switchBtn8
            // 
            this.switchBtn8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.switchBtn8.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.switchBtn8.FontAntiAlias = true;
            this.switchBtn8.ForeColor = System.Drawing.Color.Black;
            this.switchBtn8.Location = new System.Drawing.Point(1061, 12);
            this.switchBtn8.Name = "switchBtn8";
            this.switchBtn8.RoundedCornerRadius = 6;
            this.switchBtn8.Size = new System.Drawing.Size(134, 70);
            this.switchBtn8.TabIndex = 41;
            this.switchBtn8.Text = "8";
            this.switchBtn8.UseVisualStyleBackColor = true;
            this.switchBtn8.Variable = "37";
            // 
            // btnLengthRegisterDown_Right
            // 
            this.btnLengthRegisterDown_Right.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLengthRegisterDown_Right.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLengthRegisterDown_Right.FontAntiAlias = true;
            this.btnLengthRegisterDown_Right.ForeColor = System.Drawing.Color.Black;
            this.btnLengthRegisterDown_Right.Location = new System.Drawing.Point(883, 480);
            this.btnLengthRegisterDown_Right.Name = "btnLengthRegisterDown_Right";
            this.btnLengthRegisterDown_Right.RoundedCornerRadius = 6;
            this.btnLengthRegisterDown_Right.Size = new System.Drawing.Size(169, 78);
            this.btnLengthRegisterDown_Right.TabIndex = 29;
            this.btnLengthRegisterDown_Right.Text = "Length Register Down";
            this.btnLengthRegisterDown_Right.UseVisualStyleBackColor = true;
            this.btnLengthRegisterDown_Right.Variable = "8";
            // 
            // btnSideRegister_Right
            // 
            this.btnSideRegister_Right.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSideRegister_Right.BackColor = System.Drawing.Color.Snow;
            this.btnSideRegister_Right.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSideRegister_Right.FontAntiAlias = true;
            this.btnSideRegister_Right.ForeColor = System.Drawing.Color.Black;
            this.btnSideRegister_Right.Location = new System.Drawing.Point(883, 396);
            this.btnSideRegister_Right.Name = "btnSideRegister_Right";
            this.btnSideRegister_Right.RoundedCornerRadius = 6;
            this.btnSideRegister_Right.Size = new System.Drawing.Size(169, 78);
            this.btnSideRegister_Right.TabIndex = 28;
            this.btnSideRegister_Right.Text = "Side Register >";
            this.btnSideRegister_Right.UseVisualStyleBackColor = false;
            this.btnSideRegister_Right.Variable = "6";
            // 
            // btnLengthRegisterUp_Right
            // 
            this.btnLengthRegisterUp_Right.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLengthRegisterUp_Right.BackColor = System.Drawing.Color.Snow;
            this.btnLengthRegisterUp_Right.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLengthRegisterUp_Right.FontAntiAlias = true;
            this.btnLengthRegisterUp_Right.ForeColor = System.Drawing.Color.Black;
            this.btnLengthRegisterUp_Right.Location = new System.Drawing.Point(883, 312);
            this.btnLengthRegisterUp_Right.Name = "btnLengthRegisterUp_Right";
            this.btnLengthRegisterUp_Right.RoundedCornerRadius = 6;
            this.btnLengthRegisterUp_Right.Size = new System.Drawing.Size(169, 78);
            this.btnLengthRegisterUp_Right.TabIndex = 27;
            this.btnLengthRegisterUp_Right.Text = "Length Register Up";
            this.btnLengthRegisterUp_Right.UseVisualStyleBackColor = false;
            this.btnLengthRegisterUp_Right.Variable = "9";
            // 
            // btnLengthRegisterDown_Left
            // 
            this.btnLengthRegisterDown_Left.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLengthRegisterDown_Left.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLengthRegisterDown_Left.FontAntiAlias = true;
            this.btnLengthRegisterDown_Left.ForeColor = System.Drawing.Color.Black;
            this.btnLengthRegisterDown_Left.Location = new System.Drawing.Point(205, 480);
            this.btnLengthRegisterDown_Left.Name = "btnLengthRegisterDown_Left";
            this.btnLengthRegisterDown_Left.RoundedCornerRadius = 6;
            this.btnLengthRegisterDown_Left.Size = new System.Drawing.Size(169, 78);
            this.btnLengthRegisterDown_Left.TabIndex = 26;
            this.btnLengthRegisterDown_Left.Text = "Length Register Down";
            this.btnLengthRegisterDown_Left.UseVisualStyleBackColor = true;
            this.btnLengthRegisterDown_Left.Variable = "8";
            // 
            // btnSideRegister_Left
            // 
            this.btnSideRegister_Left.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSideRegister_Left.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnSideRegister_Left.FontAntiAlias = true;
            this.btnSideRegister_Left.ForeColor = System.Drawing.Color.Black;
            this.btnSideRegister_Left.Location = new System.Drawing.Point(205, 396);
            this.btnSideRegister_Left.Name = "btnSideRegister_Left";
            this.btnSideRegister_Left.RoundedCornerRadius = 6;
            this.btnSideRegister_Left.Size = new System.Drawing.Size(169, 78);
            this.btnSideRegister_Left.TabIndex = 25;
            this.btnSideRegister_Left.Text = "< Side Register";
            this.btnSideRegister_Left.UseVisualStyleBackColor = true;
            this.btnSideRegister_Left.Variable = "7";
            // 
            // btnLengthRegisterUp_left
            // 
            this.btnLengthRegisterUp_left.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLengthRegisterUp_left.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLengthRegisterUp_left.FontAntiAlias = true;
            this.btnLengthRegisterUp_left.ForeColor = System.Drawing.Color.Black;
            this.btnLengthRegisterUp_left.Location = new System.Drawing.Point(205, 312);
            this.btnLengthRegisterUp_left.Name = "btnLengthRegisterUp_left";
            this.btnLengthRegisterUp_left.RoundedCornerRadius = 6;
            this.btnLengthRegisterUp_left.Size = new System.Drawing.Size(169, 78);
            this.btnLengthRegisterUp_left.TabIndex = 24;
            this.btnLengthRegisterUp_left.Text = "Length Register Up";
            this.btnLengthRegisterUp_left.UseVisualStyleBackColor = true;
            this.btnLengthRegisterUp_left.Variable = "9";
            // 
            // btnRightLeft
            // 
            this.btnRightLeft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRightLeft.BackColor = System.Drawing.Color.Snow;
            this.btnRightLeft.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnRightLeft.FontAntiAlias = true;
            this.btnRightLeft.ForeColor = System.Drawing.Color.Black;
            this.btnRightLeft.Location = new System.Drawing.Point(734, 210);
            this.btnRightLeft.Name = "btnRightLeft";
            this.btnRightLeft.RoundedCornerRadius = 6;
            this.btnRightLeft.Size = new System.Drawing.Size(169, 78);
            this.btnRightLeft.TabIndex = 23;
            this.btnRightLeft.Text = "> <";
            this.btnRightLeft.UseVisualStyleBackColor = false;
            this.btnRightLeft.Variable = "5";
            // 
            // btnPrintOFF
            // 
            this.btnPrintOFF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrintOFF.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnPrintOFF.FontAntiAlias = true;
            this.btnPrintOFF.ForeColor = System.Drawing.Color.Black;
            this.btnPrintOFF.Location = new System.Drawing.Point(559, 210);
            this.btnPrintOFF.Name = "btnPrintOFF";
            this.btnPrintOFF.RoundedCornerRadius = 6;
            this.btnPrintOFF.Size = new System.Drawing.Size(169, 78);
            this.btnPrintOFF.TabIndex = 22;
            this.btnPrintOFF.Text = "Print OFF";
            this.btnPrintOFF.UseVisualStyleBackColor = true;
            this.btnPrintOFF.Variable = "3";
            // 
            // btnLeftRight
            // 
            this.btnLeftRight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLeftRight.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnLeftRight.FontAntiAlias = true;
            this.btnLeftRight.ForeColor = System.Drawing.Color.Black;
            this.btnLeftRight.Location = new System.Drawing.Point(384, 210);
            this.btnLeftRight.Name = "btnLeftRight";
            this.btnLeftRight.RoundedCornerRadius = 6;
            this.btnLeftRight.Size = new System.Drawing.Size(169, 78);
            this.btnLeftRight.TabIndex = 21;
            this.btnLeftRight.Text = "< >";
            this.btnLeftRight.UseVisualStyleBackColor = true;
            this.btnLeftRight.Variable = "2";
            // 
            // btnCont_Run
            // 
            this.btnCont_Run.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCont_Run.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnCont_Run.FontAntiAlias = true;
            this.btnCont_Run.ForeColor = System.Drawing.Color.Black;
            this.btnCont_Run.Location = new System.Drawing.Point(639, 122);
            this.btnCont_Run.Name = "btnCont_Run";
            this.btnCont_Run.RoundedCornerRadius = 6;
            this.btnCont_Run.Size = new System.Drawing.Size(169, 78);
            this.btnCont_Run.TabIndex = 20;
            this.btnCont_Run.Text = "Cont. Run";
            this.btnCont_Run.UseVisualStyleBackColor = true;
            this.btnCont_Run.Variable = "4";
            // 
            // btnON_OFF
            // 
            this.btnON_OFF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnON_OFF.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnON_OFF.FontAntiAlias = true;
            this.btnON_OFF.ForeColor = System.Drawing.Color.Black;
            this.btnON_OFF.Location = new System.Drawing.Point(464, 122);
            this.btnON_OFF.Name = "btnON_OFF";
            this.btnON_OFF.RoundedCornerRadius = 6;
            this.btnON_OFF.Size = new System.Drawing.Size(169, 78);
            this.btnON_OFF.TabIndex = 19;
            this.btnON_OFF.Text = "ON/OFF";
            this.btnON_OFF.UseVisualStyleBackColor = true;
            this.btnON_OFF.Variable = "1";
            // 
            // btnSeperate
            // 
            this.btnSeperate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSeperate.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnSeperate.FontAntiAlias = true;
            this.btnSeperate.ForeColor = System.Drawing.Color.Black;
            this.btnSeperate.Location = new System.Drawing.Point(814, 671);
            this.btnSeperate.Name = "btnSeperate";
            this.btnSeperate.RoundedCornerRadius = 6;
            this.btnSeperate.Size = new System.Drawing.Size(169, 78);
            this.btnSeperate.TabIndex = 18;
            this.btnSeperate.Text = "Seperate";
            this.btnSeperate.UseVisualStyleBackColor = true;
            this.btnSeperate.Variable = "13";
            // 
            // btn0_01mm
            // 
            this.btn0_01mm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn0_01mm.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btn0_01mm.FontAntiAlias = true;
            this.btn0_01mm.ForeColor = System.Drawing.Color.Black;
            this.btn0_01mm.Location = new System.Drawing.Point(639, 671);
            this.btn0_01mm.Name = "btn0_01mm";
            this.btn0_01mm.RoundedCornerRadius = 6;
            this.btn0_01mm.Size = new System.Drawing.Size(169, 78);
            this.btn0_01mm.TabIndex = 17;
            this.btn0_01mm.Text = "0.01 mm";
            this.btn0_01mm.UseVisualStyleBackColor = true;
            this.btn0_01mm.Variable = "12";
            // 
            // btn0_1mm
            // 
            this.btn0_1mm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn0_1mm.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btn0_1mm.FontAntiAlias = true;
            this.btn0_1mm.ForeColor = System.Drawing.Color.Black;
            this.btn0_1mm.Location = new System.Drawing.Point(464, 671);
            this.btn0_1mm.Name = "btn0_1mm";
            this.btn0_1mm.RoundedCornerRadius = 6;
            this.btn0_1mm.Size = new System.Drawing.Size(169, 78);
            this.btn0_1mm.TabIndex = 16;
            this.btn0_1mm.Text = "0.1 mm";
            this.btn0_1mm.UseVisualStyleBackColor = true;
            this.btn0_1mm.Variable = "11";
            // 
            // btn1mm
            // 
            this.btn1mm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn1mm.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btn1mm.FontAntiAlias = true;
            this.btn1mm.ForeColor = System.Drawing.Color.Black;
            this.btn1mm.Location = new System.Drawing.Point(289, 671);
            this.btn1mm.Name = "btn1mm";
            this.btn1mm.RoundedCornerRadius = 6;
            this.btn1mm.Size = new System.Drawing.Size(169, 78);
            this.btn1mm.TabIndex = 15;
            this.btn1mm.Text = "1 mm";
            this.btn1mm.UseVisualStyleBackColor = true;
            this.btn1mm.Variable = "10";
            // 
            // btnAniloxOUT_Right
            // 
            this.btnAniloxOUT_Right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAniloxOUT_Right.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAniloxOUT_Right.FontAntiAlias = true;
            this.btnAniloxOUT_Right.ForeColor = System.Drawing.Color.Black;
            this.btnAniloxOUT_Right.Location = new System.Drawing.Point(1083, 610);
            this.btnAniloxOUT_Right.Name = "btnAniloxOUT_Right";
            this.btnAniloxOUT_Right.RoundedCornerRadius = 6;
            this.btnAniloxOUT_Right.Size = new System.Drawing.Size(169, 78);
            this.btnAniloxOUT_Right.TabIndex = 14;
            this.btnAniloxOUT_Right.Text = "Anilox OUT";
            this.btnAniloxOUT_Right.UseVisualStyleBackColor = true;
            this.btnAniloxOUT_Right.Variable = "21";
            // 
            // btnAniloxIN_Right
            // 
            this.btnAniloxIN_Right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAniloxIN_Right.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAniloxIN_Right.FontAntiAlias = true;
            this.btnAniloxIN_Right.ForeColor = System.Drawing.Color.Black;
            this.btnAniloxIN_Right.Location = new System.Drawing.Point(1083, 526);
            this.btnAniloxIN_Right.Name = "btnAniloxIN_Right";
            this.btnAniloxIN_Right.RoundedCornerRadius = 6;
            this.btnAniloxIN_Right.Size = new System.Drawing.Size(169, 78);
            this.btnAniloxIN_Right.TabIndex = 13;
            this.btnAniloxIN_Right.Text = "Anilox IN";
            this.btnAniloxIN_Right.UseVisualStyleBackColor = true;
            this.btnAniloxIN_Right.Variable = "20";
            // 
            // btnPrintOUT_Right
            // 
            this.btnPrintOUT_Right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintOUT_Right.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrintOUT_Right.FontAntiAlias = true;
            this.btnPrintOUT_Right.ForeColor = System.Drawing.Color.Black;
            this.btnPrintOUT_Right.Location = new System.Drawing.Point(1083, 240);
            this.btnPrintOUT_Right.Name = "btnPrintOUT_Right";
            this.btnPrintOUT_Right.RoundedCornerRadius = 6;
            this.btnPrintOUT_Right.Size = new System.Drawing.Size(169, 78);
            this.btnPrintOUT_Right.TabIndex = 12;
            this.btnPrintOUT_Right.Text = "Print OUT";
            this.btnPrintOUT_Right.UseVisualStyleBackColor = true;
            this.btnPrintOUT_Right.Variable = "19";
            // 
            // btnPrintIN_Right
            // 
            this.btnPrintIN_Right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintIN_Right.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrintIN_Right.FontAntiAlias = true;
            this.btnPrintIN_Right.ForeColor = System.Drawing.Color.Black;
            this.btnPrintIN_Right.Location = new System.Drawing.Point(1083, 156);
            this.btnPrintIN_Right.Name = "btnPrintIN_Right";
            this.btnPrintIN_Right.RoundedCornerRadius = 6;
            this.btnPrintIN_Right.Size = new System.Drawing.Size(169, 78);
            this.btnPrintIN_Right.TabIndex = 11;
            this.btnPrintIN_Right.Text = "Print IN";
            this.btnPrintIN_Right.UseVisualStyleBackColor = true;
            this.btnPrintIN_Right.Variable = "18";
            // 
            // btnAniloxOUT_Left
            // 
            this.btnAniloxOUT_Left.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAniloxOUT_Left.FontAntiAlias = true;
            this.btnAniloxOUT_Left.ForeColor = System.Drawing.Color.Black;
            this.btnAniloxOUT_Left.Location = new System.Drawing.Point(12, 610);
            this.btnAniloxOUT_Left.Name = "btnAniloxOUT_Left";
            this.btnAniloxOUT_Left.RoundedCornerRadius = 6;
            this.btnAniloxOUT_Left.Size = new System.Drawing.Size(169, 78);
            this.btnAniloxOUT_Left.TabIndex = 10;
            this.btnAniloxOUT_Left.Text = "Anilox OUT";
            this.btnAniloxOUT_Left.UseVisualStyleBackColor = true;
            this.btnAniloxOUT_Left.Variable = "17";
            // 
            // btnAniloxIN_Left
            // 
            this.btnAniloxIN_Left.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAniloxIN_Left.FontAntiAlias = true;
            this.btnAniloxIN_Left.ForeColor = System.Drawing.Color.Black;
            this.btnAniloxIN_Left.Location = new System.Drawing.Point(12, 526);
            this.btnAniloxIN_Left.Name = "btnAniloxIN_Left";
            this.btnAniloxIN_Left.RoundedCornerRadius = 6;
            this.btnAniloxIN_Left.Size = new System.Drawing.Size(169, 78);
            this.btnAniloxIN_Left.TabIndex = 9;
            this.btnAniloxIN_Left.Text = "Anilox IN";
            this.btnAniloxIN_Left.UseVisualStyleBackColor = true;
            this.btnAniloxIN_Left.Variable = "16";
            // 
            // btnPrintOUT_Left
            // 
            this.btnPrintOUT_Left.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrintOUT_Left.FontAntiAlias = true;
            this.btnPrintOUT_Left.ForeColor = System.Drawing.Color.Black;
            this.btnPrintOUT_Left.Location = new System.Drawing.Point(12, 240);
            this.btnPrintOUT_Left.Name = "btnPrintOUT_Left";
            this.btnPrintOUT_Left.RoundedCornerRadius = 6;
            this.btnPrintOUT_Left.Size = new System.Drawing.Size(169, 78);
            this.btnPrintOUT_Left.TabIndex = 8;
            this.btnPrintOUT_Left.Text = "Print OUT";
            this.btnPrintOUT_Left.UseVisualStyleBackColor = true;
            this.btnPrintOUT_Left.Variable = "15";
            // 
            // btnPrintIN_Left
            // 
            this.btnPrintIN_Left.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrintIN_Left.FontAntiAlias = true;
            this.btnPrintIN_Left.ForeColor = System.Drawing.Color.Black;
            this.btnPrintIN_Left.Location = new System.Drawing.Point(12, 156);
            this.btnPrintIN_Left.Name = "btnPrintIN_Left";
            this.btnPrintIN_Left.RoundedCornerRadius = 6;
            this.btnPrintIN_Left.Size = new System.Drawing.Size(169, 78);
            this.btnPrintIN_Left.TabIndex = 7;
            this.btnPrintIN_Left.Text = "Print IN";
            this.btnPrintIN_Left.UseVisualStyleBackColor = true;
            this.btnPrintIN_Left.Variable = "14";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnExit.FontAntiAlias = true;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1180, 715);
            this.btnExit.Name = "btnExit";
            this.btnExit.RoundedCornerRadius = 6;
            this.btnExit.Size = new System.Drawing.Size(72, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Variable = null;
            this.btnExit.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.errorImage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.switchBtn1);
            this.Controls.Add(this.switchBtn2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.switchBtn3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.switchBtn4);
            this.Controls.Add(this.lbl_Anilox_DriveSide_Proxmty);
            this.Controls.Add(this.switchBtn5);
            this.Controls.Add(this.lbl_Print_DriveSide_Proxmty);
            this.Controls.Add(this.switchBtn6);
            this.Controls.Add(this.lbl_Anilox_OperatorSide_Proxmty);
            this.Controls.Add(this.switchBtn7);
            this.Controls.Add(this.lbl_Print_OperatorSide_Proxmty);
            this.Controls.Add(this.switchBtn8);
            this.Controls.Add(this.lbl_SideRight);
            this.Controls.Add(this.lbl_SideLeft);
            this.Controls.Add(this.btnLengthRegisterDown_Right);
            this.Controls.Add(this.btnSideRegister_Right);
            this.Controls.Add(this.btnLengthRegisterUp_Right);
            this.Controls.Add(this.btnLengthRegisterDown_Left);
            this.Controls.Add(this.btnSideRegister_Left);
            this.Controls.Add(this.btnLengthRegisterUp_left);
            this.Controls.Add(this.btnRightLeft);
            this.Controls.Add(this.btnPrintOFF);
            this.Controls.Add(this.btnLeftRight);
            this.Controls.Add(this.btnCont_Run);
            this.Controls.Add(this.btnON_OFF);
            this.Controls.Add(this.btnSeperate);
            this.Controls.Add(this.btn0_01mm);
            this.Controls.Add(this.btn0_1mm);
            this.Controls.Add(this.btn1mm);
            this.Controls.Add(this.btnAniloxOUT_Right);
            this.Controls.Add(this.btnAniloxIN_Right);
            this.Controls.Add(this.btnPrintOUT_Right);
            this.Controls.Add(this.btnPrintIN_Right);
            this.Controls.Add(this.btnAniloxOUT_Left);
            this.Controls.Add(this.btnAniloxIN_Left);
            this.Controls.Add(this.btnPrintOUT_Left);
            this.Controls.Add(this.btnPrintIN_Left);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Lenze Desktop Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GlassButton btnExit;
        private GlassButton switchBtn1;
        private GlassButton switchBtn2;
        private GlassButton switchBtn3;
        private GlassButton switchBtn4;
        private GlassButton switchBtn5;
        private GlassButton switchBtn6;
        private GlassButton btnPrintIN_Left;
        private GlassButton btnPrintOUT_Left;
        private GlassButton btnAniloxOUT_Left;
        private GlassButton btnAniloxIN_Left;
        private GlassButton btnAniloxOUT_Right;
        private GlassButton btnAniloxIN_Right;
        private GlassButton btnPrintOUT_Right;
        private GlassButton btnPrintIN_Right;
        private GlassButton btnSeperate;
        private GlassButton btn0_01mm;
        private GlassButton btn0_1mm;
        private GlassButton btn1mm;
        private GlassButton btnCont_Run;
        private GlassButton btnON_OFF;
        private GlassButton btnPrintOFF;
        private GlassButton btnLeftRight;
        private GlassButton btnRightLeft;
        private GlassButton btnSideRegister_Left;
        private GlassButton btnLengthRegisterUp_left;
        private GlassButton btnLengthRegisterDown_Left;
        private GlassButton btnLengthRegisterDown_Right;
        private System.Windows.Forms.Label lbl_SideLeft;
        private System.Windows.Forms.Label lbl_SideRight;
        private System.Windows.Forms.Label lbl_Print_OperatorSide_Proxmty;
        private System.Windows.Forms.Label lbl_Anilox_OperatorSide_Proxmty;
        private System.Windows.Forms.Label lbl_Anilox_DriveSide_Proxmty;
        private System.Windows.Forms.Label lbl_Print_DriveSide_Proxmty;
        private GlassButton btnSideRegister_Right;
        private GlassButton btnLengthRegisterUp_Right;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_LengthRegisterPosition_Actuel;
        private System.Windows.Forms.Label lbl_SideRegisterPosition_Actual;
        private System.Windows.Forms.Label lbl_LengthRegisterPosition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private GlassButton switchBtn8;
        private GlassButton switchBtn7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label actuelMeter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label machineSpeed;
        private System.Windows.Forms.PictureBox errorImage;
    }
}

//GlassButton
//GlassButton