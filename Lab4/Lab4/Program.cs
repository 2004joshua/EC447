using System;
using System.Windows.Forms;

namespace Lab4 // uppercase "L" in namespace
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new lab4()); 
        }
    }
}
