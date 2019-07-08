using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Lenze.Desktop.View
{
    public partial class NumericKeypad : Form
    {
        private bool _allowDecimals;

        private bool _allowNegatives;

        private string _data = "";

        public NumericKeypad()
        {
            InitializeComponent();
            TopMost = true;
        }

        public string Data
        {
            get => _data;
            set
            {
                _data = value;
                buDisplay.Text = value == "" ? "0" : value;
            }
        }

        public bool AllowNegatives
        {
            get => _allowNegatives;
            set
            {
                _allowNegatives = value;
                buNegative.Visible = value;
                if ((Data.Substring(0, 1) == "-") & (value == false))
                    Data = Data.Substring(1, Data.Length - 1);
            }
        }

        public bool AllowDecimals
        {
            get => _allowDecimals;
            set
            {
                _allowDecimals = value;
                buDecimal.Visible = value;
                if (Data.Contains(".") & (value == false))
                    Data = Math.Round(Conversion.Val(Data), 0).ToString();
            }
        }

        private void NumericMouseUp(object sender, MouseEventArgs e)
        {
            var send = (Button) sender;
            if ((send == Button0) & (_data == "0"))
                return;
            Data += send.Text;
        }

        private void BuBksp_MouseUp(object sender, MouseEventArgs e)
        {
            Data = Data.Length == 0 ? "" : Data.Substring(0, Data.Length - 1);
        }

        private void BuClear_MouseUp(object sender, MouseEventArgs e)
        {
            Data = "";
        }

        private void BuCancel_MouseUp(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            TopMost = false;
            Close();
        }

        private void BuAccept_MouseUp(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.OK;
            TopMost = false;
            Close();
        }

        private void BuNegative_MouseUp(object sender, MouseEventArgs e)
        {
            if (Data.Contains("-") == false)
                Data = "-" + Data;
            else
                Data = Data.Substring(1, Data.Length - 1);
        }

        private void BuDecimal_MouseUp(object sender, MouseEventArgs e)
        {
            if (Data.Contains(".") == false)
                Data += ".";
        }

        private void NumericKeypad_FormClosing(object sender, FormClosingEventArgs e)
        {
            TopMost = false;
        }
    }
}