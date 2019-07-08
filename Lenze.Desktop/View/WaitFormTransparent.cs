using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lenze.Desktop.View
{
    public partial class WaitFormTransparent : Form
    {
        private WaitControl waitControl1;
        private void AddControl(string message, string title)
        {
            this.waitControl1 = new Lenze.Desktop.View.WaitControl(message, title);
            this.waitControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                              | System.Windows.Forms.AnchorStyles.Left)
                                                                             | System.Windows.Forms.AnchorStyles.Right)));
            this.waitControl1.Location = new System.Drawing.Point(429, 310);
            this.waitControl1.Name = "waitControl1";
            this.waitControl1.Size = new System.Drawing.Size(391, 114);
            this.waitControl1.TabIndex = 0;

            this.Controls.Add(this.waitControl1);
        }

        public WaitFormTransparent(Action worker)
        {
            InitializeComponent();
            AddControl("İşleminiz gerçekleştiriliyor....", "Lütfen bekleyiniz...");

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent; // I had to add this to get it to work.

            Worker = worker ?? throw new ArgumentNullException();
        }

        protected override void OnPaintBackground(PaintEventArgs e) { /* Ignore */ }

        public Action Worker { get; set; }

        public WaitFormTransparent(Action worker, string message, string title)
        {
            InitializeComponent();
            AddControl(message, title);
            Worker = worker ?? throw new ArgumentNullException();
        }

        public WaitFormTransparent(Action worker, string message)
        {
            InitializeComponent();
            AddControl(message, "Lütfen bekleyiniz...");
            Worker = worker ?? throw new ArgumentNullException();
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
