﻿using EStore.Auth;
using EStore_Temp.Main;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EStore_Temp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
        }
    }
}