using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.Data;
using PGS.Business;
using PGS.Entity;
using PGS.Global;
using Telerik.WinControls.UI.Localization;
namespace PGS.Controls
{
    public partial class LoginControl : UserControl
    {
        private PGS.Entity.PGSDBEntities dbContext = EQ_MainForm.dbContext;
        public delegate void LoginStatusChanged(bool isSuccessed);
        public event LoginStatusChanged LoginStatusChangedHandler;
        public LoginControl()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginStatusChangedHandler(true); 
            //try
            //{
            //    string userName = txtUserName.Text;
            //    string pass = txtPassword.Text;
            //    User logedUser = dbContext.Users.FirstOrDefault(u => u.UserName == userName && u.UserPwd == pass);
            //    if (logedUser != null)
            //    {
            //        Global.AppContext.CurrentUser = logedUser;
            //        if (LoginStatusChangedHandler != null)
            //            LoginStatusChangedHandler(true);
            //    }
            //    else
            //    {
            //        LoginStatusChangedHandler(false);
            //    }
            //}
            //catch
            //{
            //    LoginStatusChangedHandler(false);
            //}
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }
    }
}
