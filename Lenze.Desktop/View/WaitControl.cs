using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Lenze.Desktop.View
{
    public partial class WaitControl : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public WaitControl(string message, string title)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            lblMessage.Text = message;
            lblTitle.Text = title;
        }

        public WaitControl(string message)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            lblMessage.Text = message;
            lblTitle.Text = "Lütfen bekleyiniz...";
        }
        public WaitControl()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            lblMessage.Text = "İşleminiz gerçekleştiriliyor....";
            lblTitle.Text = "Lütfen bekleyiniz...";
        }
    }
}
