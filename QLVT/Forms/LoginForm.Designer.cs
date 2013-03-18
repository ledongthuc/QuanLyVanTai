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
            this.mainButtonsControl = new PGS.Controls.MainButtonsControl();
            this.loginControl = new PGS.Controls.LoginControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // mainButtonsControl
            // 
            this.mainButtonsControl.BackColor = System.Drawing.Color.Transparent;
            this.mainButtonsControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainButtonsControl.Location = new System.Drawing.Point(-2, 3);
            this.mainButtonsControl.Name = "mainButtonsControl";
            this.mainButtonsControl.Size = new System.Drawing.Size(498, 141);
            this.mainButtonsControl.TabIndex = 1;
            this.mainButtonsControl.MainButtonClickedHandler += new PGS.Controls.MainButtonsControl.MainButtonClicked(this.mainButtonsControl_MainButtonClickedHandler);
            // 
            // loginControl
            // 
            this.loginControl.BackColor = System.Drawing.Color.LemonChiffon;
            this.loginControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginControl.Location = new System.Drawing.Point(97, 91);
            this.loginControl.Name = "loginControl";
            this.loginControl.Size = new System.Drawing.Size(300, 140);
            this.loginControl.TabIndex = 0;
            this.loginControl.LoginStatusChangedHandler += new PGS.Controls.LoginControl.LoginStatusChanged(this.loginControl_LoginStatusChangedHandler);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::PGS.Properties.Resources.PTSC_PGS;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 50);
            this.panel1.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PGS.Properties.Resources.ROV;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 322);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginControl);
            this.Controls.Add(this.mainButtonsControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EQUIPMENT/TOOLS/CONSUMABLES MANAGEMENT SOFTWARE";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MainButtonsControl mainButtonsControl;
        private Controls.LoginControl loginControl;
        private System.Windows.Forms.Panel panel1;
    }
}