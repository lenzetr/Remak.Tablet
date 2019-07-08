using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lenze.Desktop.View
{
    public partial class WaitForm : Form
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

        public Action Worker { get; set; }

        public WaitForm(Action worker, string message, string title)
        {
            InitializeComponent();
            Worker = worker ?? throw new ArgumentNullException();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            lblMessage.Text = message;
            lblTitle.Text = title;
        }

        public WaitForm(Action worker, string message)
        {
            InitializeComponent();
            Worker = worker ?? throw new ArgumentNullException();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            lblMessage.Text = message;
            lblTitle.Text = "Lütfen bekleyiniz...";
        }
        public WaitForm(Action worker)
        {
            InitializeComponent();
            Worker = worker ?? throw new ArgumentNullException();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            lblMessage.Text = "İşleminiz gerçekleştiriliyor....";
            lblTitle.Text = "Lütfen bekleyiniz...";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //Start new thread to run wait form dialog
            Task.Factory.StartNew(Worker).ContinueWith(t => {
                this.Close();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Worker = null;
        }
    }
}
