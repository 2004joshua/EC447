﻿using System;
using System.Windows.Forms;

namespace Lab3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Lab3());  // Use Lab3 as the main form
        }
    }
}