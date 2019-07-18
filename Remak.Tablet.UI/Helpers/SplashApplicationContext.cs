using System;
using System.Windows.Forms;

namespace Remak.Tablet.UI.Helpers
{
    /// <summary>
    ///     The SplashApplicationContext is used to show a splash Form before the main Form is shown.
    /// </summary>
    /// <remarks>
    ///     Copyright © 2002 Reflection IT
    ///     This software is provided 'as-is', without any express or implied warranty.
    ///     In no event will the authors be held liable for any damages arising from the
    ///     use of this software.
    ///     Permission is granted to anyone to use this software for any purpose,
    ///     including commercial applications, subject to the following restrictions:
    ///     1. The origin of this software must not be misrepresented; you must not claim
    ///     that you wrote the original software.
    ///     2. No substantial portion of the source code of this library may be redistributed
    ///     without the express written permission of the copyright holders, where
    ///     "substantial" is defined as enough code to be recognizably from this library.
    /// </remarks>
    public class SplashApplicationContext : ApplicationContext
    {
        private readonly Form _myMainForm;
        private readonly Timer _myTimer;

        /// <summary>
        ///     Initializes a new instance of SplashContext.
        ///     A default timeout of 2000 miliseconds is used.
        /// </summary>
        /// <param name="mainForm">The main Form of the application to use for context</param>
        /// <param name="splashForm">The splash Form of the application to use for context</param>
        public SplashApplicationContext(Form mainForm, Form splashForm) : this(mainForm, splashForm, 2000)
        {
            _myMainForm = mainForm;
            SplashForm = splashForm;

            // Initialize the SplashForm
            splashForm.ShowInTaskbar = false;
            splashForm.FormBorderStyle = FormBorderStyle.None;
            splashForm.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        ///     Initializes a new instance of SplashContext
        /// </summary>
        /// <param name="mainForm">The main Form of the application to use for context</param>
        /// <param name="splashForm">The splash Form of the application to use for context</param>
        /// <param name="timeout">The time (in milliseconds) the splash Form is visible. Specify 0 to disable the timeout.</param>
        public SplashApplicationContext(Form mainForm, Form splashForm, int timeout) : base(splashForm)
        {
            _myMainForm = mainForm;
            SplashForm = splashForm;

            // Initialize the SplashForm
            splashForm.ShowInTaskbar = false;
            splashForm.FormBorderStyle = FormBorderStyle.None;
            splashForm.StartPosition = FormStartPosition.CenterScreen;

            // Initialize the Timer
            if (timeout <= 0) return;
            _myTimer = new Timer {Interval = timeout};
            _myTimer.Tick += TimerEventProcessor;
            _myTimer.Enabled = true;
            _myTimer.Start();
        }

        /// <summary>
        ///     gets the splash Form
        /// </summary>
        public Form SplashForm { get; }

        private void TimerEventProcessor(object myObject, EventArgs myEventArgs)
        {
            CloseSplashForm();
        }

        /// <summary>
        ///     Close the splash Form
        /// </summary>
        public void CloseSplashForm()
        {
            if (MainForm == _myMainForm) return;
            _myTimer.Enabled = false;
            _myTimer.Stop();
            base.MainForm.Close();
        }

        protected override void OnMainFormClosed(object sender, EventArgs e)
        {

            if (MainForm == _myMainForm)
            {
                base.OnMainFormClosed(sender, e);
            }
            else
            {
                MainForm = _myMainForm;
                MainForm.Show();
            }
        }
    }
}