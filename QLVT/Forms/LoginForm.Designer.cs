namespace PGS.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainButtonsControl = new PGS.Controls.MainButtonsControl();
            this.loginControl = new PGS.Controls.LoginControl();
            this.languageControl1 = new PGS.Controls.LanguageControl();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::PGS.Properties.Resources.PTSC_PGS;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // mainButtonsControl
            // 
            this.mainButtonsControl.BackColor = System.Drawing.Color.Transparent;
            this.mainButtonsControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.mainButtonsControl, "mainButtonsControl");
            this.mainButtonsControl.Name = "mainButtonsControl";
            this.mainButtonsControl.MainButtonClickedHandler += new PGS.Controls.MainButtonsControl.MainButtonClicked(this.mainButtonsControl_MainButtonClickedHandler);
            // 
            // loginControl
            // 
            this.loginControl.BackColor = System.Drawing.Color.LemonChiffon;
            this.loginControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.loginControl, "loginControl");
            this.loginControl.Name = "loginControl";
            this.loginControl.LoginStatusChangedHandler += new PGS.Controls.LoginControl.LoginStatusChanged(this.loginControl_LoginStatusChangedHandler);
            // 
            // languageControl1
            // 
            resources.ApplyResources(this.languageControl1, "languageControl1");
            this.languageControl1.Name = "languageControl1";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PGS.Properties.Resources.ROV;
            this.Controls.Add(this.languageControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginControl);
            this.Controls.Add(this.mainButtonsControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MainButtonsControl mainButtonsControl;
        private Controls.LoginControl loginControl;
        private System.Windows.Forms.Panel panel1;
        private Controls.LanguageControl languageControl1;
    }
}