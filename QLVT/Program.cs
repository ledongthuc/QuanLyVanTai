﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PGS.Forms;

namespace PGS {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);
        }
    }
}
