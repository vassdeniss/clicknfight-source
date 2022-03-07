using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Linq;

namespace ClickNFight.Windows
{
    public partial class Name : Form
    {
        public Name()
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        [DllImport("user32.dll")]
        static extern int PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        private const uint WM_CLOSE = 0x0010;

        public void ShowAutoClosingMessageBox(string message, string caption)
        {
            System.Timers.Timer timer = new System.Timers.Timer(2000) { AutoReset = false };
            timer.Elapsed += delegate
            {
                IntPtr hWnd = FindWindowByCaption(IntPtr.Zero, caption);
                if (hWnd.ToInt32() != 0) PostMessage(hWnd, WM_CLOSE, 0, 0);
            };
            timer.Enabled = true;
            MessageBox.Show(message, caption);
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txName.Text)) 
            {
                MessageBox.Show("Please enter a save name!", "Warning!", MessageBoxButtons.OK);
                return;
            } 

            string[] specialNames = { "GCND", "Green Cyborg Ninja Dude", "Andrej", "Green", "Ando" };
            Engine.name = txName.Text;
            if (specialNames.Contains(Engine.name))
            {
                ShowAutoClosingMessageBox("Hewwoooooo Ando! ^w^", "Oh hi there!");
            }

            Close();
        }
    }
}
