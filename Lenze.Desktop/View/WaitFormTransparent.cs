using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lenze.Desktop.View
{
    public partial class WaitFormTransparent : Form
    {
        private WaitControl _waitControl1;
        private System.Windows.Forms.Timer _timer;

        public WaitFormTransparent(Action worker)
        {
            InitializeComponent();
            AddControl("İşleminiz gerçekleştiriliyor....", "Lütfen bekleyiniz...");

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            TransparencyKey = Color.Transparent; // I had to add this to get it to work.

            Worker = worker ?? throw new ArgumentNullException();
        }

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

        public Action Worker { get; set; }

        private void AddControl(string message, string title)
        {
            _waitControl1 = new WaitControl(message, title)
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                                          | AnchorStyles.Left
                                          | AnchorStyles.Right,
                Location = new Point(429, 310),
                Name = "waitControl1",
                Size = new Size(391, 114),
                TabIndex = 0
            };

            Controls.Add(_waitControl1);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            /* Ignore */
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            TopMost = true;
            Global.IsDisplayWait = true;

            _timer = new System.Windows.Forms.Timer();
            _timer.Tick += _timer_Tick;
            _timer.Interval = (int)TimeSpan.FromMinutes(1).TotalMilliseconds;
            _timer.Start();

            //Start new thread to run wait form dialog
            Task.Factory.StartNew(Worker)
                .ContinueWith(t => { Close(); }, TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WaitFormTransparent_FormClosing(object sender, FormClosingEventArgs e)
        {
            TopMost = false;
            Global.IsDisplayWait = false;
        }
    }
}