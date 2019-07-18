namespace Remak.Tablet.UI.View
{
    partial class NumericKeypad
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buNegative = new Remak.Tablet.UI.FlatButton();
            this.buDecimal = new Remak.Tablet.UI.FlatButton();
            this.buDisplay = new Remak.Tablet.UI.FlatButton();
            this.Button0 = new Remak.Tablet.UI.FlatButton();
            this.Button9 = new Remak.Tablet.UI.FlatButton();
            this.Button8 = new Remak.Tablet.UI.FlatButton();
            this.Button7 = new Remak.Tablet.UI.FlatButton();
            this.Button6 = new Remak.Tablet.UI.FlatButton();
            this.Button5 = new Remak.Tablet.UI.FlatButton();
            this.Button4 = new Remak.Tablet.UI.FlatButton();
            this.Button3 = new Remak.Tablet.UI.FlatButton();
            this.Button2 = new Remak.Tablet.UI.FlatButton();
            this.Button1 = new Remak.Tablet.UI.FlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buAccept = new Remak.Tablet.UI.FlatButton();
            this.buCancel = new Remak.Tablet.UI.FlatButton();
            this.buClear = new Remak.Tablet.UI.FlatButton();
            this.buBksp = new Remak.Tablet.UI.FlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buNegative);
            this.panel1.Controls.Add(this.buDecimal);
            this.panel1.Controls.Add(this.buDisplay);
            this.panel1.Controls.Add(this.Button0);
            this.panel1.Controls.Add(this.Button9);
            this.panel1.Controls.Add(this.Button8);
            this.panel1.Controls.Add(this.Button7);
            this.panel1.Controls.Add(this.Button6);
            this.panel1.Controls.Add(this.Button5);
            this.panel1.Controls.Add(this.Button4);
            this.panel1.Controls.Add(this.Button3);
            this.panel1.Controls.Add(this.Button2);
            this.panel1.Controls.Add(this.Button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 420);
            this.panel1.TabIndex = 0;
            // 
            // buNegative
            // 
            this.buNegative.BackColor = System.Drawing.Color.DodgerBlue;
            this.buNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buNegative.ForeColor = System.Drawing.Color.White;
            this.buNegative.Location = new System.Drawing.Point(11, 338);
            this.buNegative.Name = "buNegative";
            this.buNegative.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.buNegative.Size = new System.Drawing.Size(88, 75);
            this.buNegative.TabIndex = 29;
            this.buNegative.Text = "-";
            this.buNegative.UseVisualStyleBackColor = true;
            this.buNegative.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BuNegative_MouseUp);
            // 
            // buDecimal
            // 
            this.buDecimal.BackColor = System.Drawing.Color.DodgerBlue;
            this.buDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buDecimal.ForeColor = System.Drawing.Color.White;
            this.buDecimal.Location = new System.Drawing.Point(199, 338);
            this.buDecimal.Name = "buDecimal";
            this.buDecimal.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.buDecimal.Size = new System.Drawing.Size(88, 75);
            this.buDecimal.TabIndex = 28;
            this.buDecimal.Text = ".";
            this.buDecimal.UseVisualStyleBackColor = true;
            this.buDecimal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumericMouseUp);
            // 
            // buDisplay
            // 
            this.buDisplay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buDisplay.Enabled = false;
            this.buDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buDisplay.ForeColor = System.Drawing.Color.White;
            this.buDisplay.Location = new System.Drawing.Point(11, 12);
            this.buDisplay.Name = "buDisplay";
            this.buDisplay.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.buDisplay.Size = new System.Drawing.Size(276, 75);
            this.buDisplay.TabIndex = 27;
            this.buDisplay.TabStop = false;
            this.buDisplay.Text = "0";
            this.buDisplay.UseVisualStyleBackColor = false;
            // 
            // Button0
            // 
            this.Button0.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button0.ForeColor = System.Drawing.Color.White;
            this.Button0.Location = new System.Drawing.Point(105, 338);
            this.Button0.Name = "Button0";
            this.Button0.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.Button0.Size = new System.Drawing.Size(88, 75);
            this.Button0.TabIndex = 26;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumericMouseUp);
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button9.ForeColor = System.Drawing.Color.White;
            this.Button9.Location = new System.Drawing.Point(199, 257);
            this.Button9.Name = "Button9";
            this.Button9.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.Button9.Size = new System.Drawing.Size(88, 75);
            this.Button9.TabIndex = 25;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumericMouseUp);
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button8.ForeColor = System.Drawing.Color.White;
            this.Button8.Location = new System.Drawing.Point(105, 257);
            this.Button8.Name = "Button8";
            this.Button8.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.Button8.Size = new System.Drawing.Size(88, 75);
            this.Button8.TabIndex = 24;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumericMouseUp);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.ForeColor = System.Drawing.Color.White;
            this.Button7.Location = new System.Drawing.Point(11, 257);
            this.Button7.Name = "Button7";
            this.Button7.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.Button7.Size = new System.Drawing.Size(88, 75);
            this.Button7.TabIndex = 23;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumericMouseUp);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.ForeColor = System.Drawing.Color.White;
            this.Button6.Location = new System.Drawing.Point(199, 176);
            this.Button6.Name = "Button6";
            this.Button6.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.Button6.Size = new System.Drawing.Size(88, 75);
            this.Button6.TabIndex = 22;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumericMouseUp);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.Color.White;
            this.Button5.Location = new System.Drawing.Point(105, 176);
            this.Button5.Name = "Button5";
            this.Button5.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.Button5.Size = new System.Drawing.Size(88, 75);
            this.Button5.TabIndex = 21;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumericMouseUp);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.Color.White;
            this.Button4.Location = new System.Drawing.Point(11, 176);
            this.Button4.Name = "Button4";
            this.Button4.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.Button4.Size = new System.Drawing.Size(88, 75);
            this.Button4.TabIndex = 20;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumericMouseUp);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(199, 95);
            this.Button3.Name = "Button3";
            this.Button3.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.Button3.Size = new System.Drawing.Size(88, 75);
            this.Button3.TabIndex = 19;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumericMouseUp);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(105, 95);
            this.Button2.Name = "Button2";
            this.Button2.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.Button2.Size = new System.Drawing.Size(88, 75);
            this.Button2.TabIndex = 18;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumericMouseUp);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(11, 95);
            this.Button1.Name = "Button1";
            this.Button1.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.Button1.Size = new System.Drawing.Size(88, 75);
            this.Button1.TabIndex = 17;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumericMouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buAccept);
            this.panel2.Controls.Add(this.buCancel);
            this.panel2.Controls.Add(this.buClear);
            this.panel2.Controls.Add(this.buBksp);
            this.panel2.Location = new System.Drawing.Point(324, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 422);
            this.panel2.TabIndex = 1;
            // 
            // buAccept
            // 
            this.buAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buAccept.BackColor = System.Drawing.Color.DodgerBlue;
            this.buAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buAccept.ForeColor = System.Drawing.Color.White;
            this.buAccept.Location = new System.Drawing.Point(8, 340);
            this.buAccept.Name = "buAccept";
            this.buAccept.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.buAccept.Size = new System.Drawing.Size(144, 75);
            this.buAccept.TabIndex = 18;
            this.buAccept.Text = "Accept";
            this.buAccept.UseVisualStyleBackColor = true;
            this.buAccept.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BuAccept_MouseUp);
            // 
            // buCancel
            // 
            this.buCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.buCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buCancel.ForeColor = System.Drawing.Color.White;
            this.buCancel.Location = new System.Drawing.Point(8, 250);
            this.buCancel.Name = "buCancel";
            this.buCancel.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.buCancel.Size = new System.Drawing.Size(144, 75);
            this.buCancel.TabIndex = 17;
            this.buCancel.Text = "Cancel";
            this.buCancel.UseVisualStyleBackColor = true;
            this.buCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BuCancel_MouseUp);
            // 
            // buClear
            // 
            this.buClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buClear.BackColor = System.Drawing.Color.DodgerBlue;
            this.buClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buClear.ForeColor = System.Drawing.Color.White;
            this.buClear.Location = new System.Drawing.Point(8, 106);
            this.buClear.Name = "buClear";
            this.buClear.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.buClear.Size = new System.Drawing.Size(144, 75);
            this.buClear.TabIndex = 16;
            this.buClear.Text = "Clear";
            this.buClear.UseVisualStyleBackColor = true;
            this.buClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BuClear_MouseUp);
            // 
            // buBksp
            // 
            this.buBksp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buBksp.BackColor = System.Drawing.Color.DodgerBlue;
            this.buBksp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buBksp.ForeColor = System.Drawing.Color.White;
            this.buBksp.Location = new System.Drawing.Point(8, 15);
            this.buBksp.Name = "buBksp";
            this.buBksp.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.buBksp.Size = new System.Drawing.Size(144, 75);
            this.buBksp.TabIndex = 15;
            this.buBksp.Text = "Backspace";
            this.buBksp.UseVisualStyleBackColor = true;
            this.buBksp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BuBksp_MouseUp);
            // 
            // NumericKeypad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 443);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NumericKeypad";
            this.Text = "NumericKeypad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NumericKeypad_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal FlatButton buNegative;
        internal FlatButton buDecimal;
        internal FlatButton buDisplay;
        internal FlatButton Button0;
        internal FlatButton Button9;
        internal FlatButton Button8;
        internal FlatButton Button7;
        internal FlatButton Button6;
        internal FlatButton Button5;
        internal FlatButton Button4;
        internal FlatButton Button3;
        internal FlatButton Button2;
        internal FlatButton Button1;
        private System.Windows.Forms.Panel panel2;
        internal FlatButton buAccept;
        internal FlatButton buCancel;
        internal FlatButton buClear;
        internal FlatButton buBksp;
    }
}