using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PGS.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private int mainFormMode = 0;

        public int MainFormMode
        {
            get { return mainFormMode; }
            set { mainFormMode = value; }
        }

       

        private void InitLoginControl()
        {
            this.loginControl.Location = new Point((this.Width - this.loginControl.Width) / 2,
                                                (this.Height - this.loginControl.Height) / 2);
            this.loginControl.Visible = true;
            this.mainButtonsControl.Visible = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            InitLoginControl();
        }
        private void mainButtonsControl_MainButtonClickedHandler(int value)
        {
            this.MainFormMode = value;
            this.Hide();
            EQ_MainForm mainForm = new EQ_MainForm();
            mainForm.SetActiveRibbonBar(value);
            mainForm.ShowDialog();
            this.Show();
        }
        private void loginControl_LoginStatusChangedHandler(bool isSuccessed)
        {
            if (isSuccessed)
            {
                loginControl.Visible = false;
                InitMainButtonsControl();
                mainButtonsControl_MainButtonClickedHandler(3); // set to use for Equipment Management only
            }
            else
            {
                Utils.Helper.ShowError("Login failed!\r\nPlease check the connection to database server or\r\n Input your account again.");
            }
        }

        private void InitMainButtonsControl()
        {
            this.mainButtonsControl.Location = new Point((this.Width - this.mainButtonsControl.Width) / 2,
                                                (this.Height - this.mainButtonsControl.Height) / 2);
            this.mainButtonsControl.Visible = true;
        }
    }
}
