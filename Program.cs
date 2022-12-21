using System;
using System.Windows.Forms;

namespace Idle_Game
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles(); 
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run((Form)new MainMenu());
        }
    }
}