using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Idle_Game
{
    public partial class Name : Form
    {
        public Name()
        {
            InitializeComponent();
            this.Icon = Idle_Game.Properties.Resources.icon;
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
        static extern int PostMessage(IntPtr hWnd, UInt32 msg, int wParam, int lParam);

        private const UInt32 WM_CLOSE = 0x0010;

        public void ShowAutoClosingMessageBox(string message, string caption)
        {
            var timer = new System.Timers.Timer(2000) { AutoReset = false };
            timer.Elapsed += delegate
            {
                IntPtr hWnd = FindWindowByCaption(IntPtr.Zero, caption);
                if (hWnd.ToInt32() != 0) PostMessage(hWnd, WM_CLOSE, 0, 0);
            };
            timer.Enabled = true;
            MessageBox.Show(message, caption);
        }

        private void dnoe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txName.Text)) 
            {
                var warning = MessageBox.Show("Please enter a save name!", "Warning!", MessageBoxButtons.OK);
            } 
            else
            {
                Engine.name = txName.Text;
                if (Engine.name == "GCND")
                {
                    ShowAutoClosingMessageBox("Hewwoooooo Ando! ^w^", "Oh hi therw!");
                    this.Close();
                }
                else if (Engine.name == "Green Cyborg Ninja Dude")
                {
                    ShowAutoClosingMessageBox("Hewwoooooo Ando! ^w^", "Oh hi therw!");
                    this.Close();
                }
                else if (Engine.name == "Andrej")
                {
                    ShowAutoClosingMessageBox("Hewwoooooo Ando! ^w^", "Oh hi therw!");
                    this.Close();
                }
                else if (Engine.name == "Green")
                {
                    ShowAutoClosingMessageBox("Hewwoooooo Ando! ^w^", "Oh hi therw!");
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
