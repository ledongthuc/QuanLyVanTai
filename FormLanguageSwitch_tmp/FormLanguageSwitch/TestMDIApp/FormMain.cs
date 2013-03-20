using System;
using System.Drawing;
using System.Collections;
using System.Globalization;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.Data;

namespace TestMDIApp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FormMain : System.Windows.Forms.Form
	{
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormMain));
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                     this.menuItem1,
                                                                                     this.menuItem3,
                                                                                     this.menuItem5});
            this.mainMenu.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("mainMenu.RightToLeft")));
            // 
            // menuItem1
            // 
            this.menuItem1.Enabled = ((bool)(resources.GetObject("menuItem1.Enabled")));
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                      this.menuItem2});
            this.menuItem1.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItem1.Shortcut")));
            this.menuItem1.ShowShortcut = ((bool)(resources.GetObject("menuItem1.ShowShortcut")));
            this.menuItem1.Text = resources.GetString("menuItem1.Text");
            this.menuItem1.Visible = ((bool)(resources.GetObject("menuItem1.Visible")));
            // 
            // menuItem2
            // 
            this.menuItem2.Enabled = ((bool)(resources.GetObject("menuItem2.Enabled")));
            this.menuItem2.Index = 0;
            this.menuItem2.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItem2.Shortcut")));
            this.menuItem2.ShowShortcut = ((bool)(resources.GetObject("menuItem2.ShowShortcut")));
            this.menuItem2.Text = resources.GetString("menuItem2.Text");
            this.menuItem2.Visible = ((bool)(resources.GetObject("menuItem2.Visible")));
            // 
            // menuItem3
            // 
            this.menuItem3.Enabled = ((bool)(resources.GetObject("menuItem3.Enabled")));
            this.menuItem3.Index = 1;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                      this.menuItem4});
            this.menuItem3.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItem3.Shortcut")));
            this.menuItem3.ShowShortcut = ((bool)(resources.GetObject("menuItem3.ShowShortcut")));
            this.menuItem3.Text = resources.GetString("menuItem3.Text");
            this.menuItem3.Visible = ((bool)(resources.GetObject("menuItem3.Visible")));
            // 
            // menuItem4
            // 
            this.menuItem4.Enabled = ((bool)(resources.GetObject("menuItem4.Enabled")));
            this.menuItem4.Index = 0;
            this.menuItem4.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItem4.Shortcut")));
            this.menuItem4.ShowShortcut = ((bool)(resources.GetObject("menuItem4.ShowShortcut")));
            this.menuItem4.Text = resources.GetString("menuItem4.Text");
            this.menuItem4.Visible = ((bool)(resources.GetObject("menuItem4.Visible")));
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Enabled = ((bool)(resources.GetObject("menuItem5.Enabled")));
            this.menuItem5.Index = 2;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                      this.menuItem6});
            this.menuItem5.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItem5.Shortcut")));
            this.menuItem5.ShowShortcut = ((bool)(resources.GetObject("menuItem5.ShowShortcut")));
            this.menuItem5.Text = resources.GetString("menuItem5.Text");
            this.menuItem5.Visible = ((bool)(resources.GetObject("menuItem5.Visible")));
            // 
            // menuItem6
            // 
            this.menuItem6.Enabled = ((bool)(resources.GetObject("menuItem6.Enabled")));
            this.menuItem6.Index = 0;
            this.menuItem6.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItem6.Shortcut")));
            this.menuItem6.ShowShortcut = ((bool)(resources.GetObject("menuItem6.ShowShortcut")));
            this.menuItem6.Text = resources.GetString("menuItem6.Text");
            this.menuItem6.Visible = ((bool)(resources.GetObject("menuItem6.Visible")));
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // FormMain
            // 
            this.AccessibleDescription = ((string)(resources.GetObject("$this.AccessibleDescription")));
            this.AccessibleName = ((string)(resources.GetObject("$this.AccessibleName")));
            this.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("$this.Anchor")));
            this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
            this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
            this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
            this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
            this.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("$this.Dock")));
            this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
            this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
            this.IsMdiContainer = true;
            this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
            this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
            this.Menu = this.mainMenu;
            this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
            this.Name = "FormMain";
            this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
            this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
            this.Text = resources.GetString("$this.Text");
            this.Visible = ((bool)(resources.GetObject("$this.Visible")));

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FormMain());
		}

        private void menuItem6_Click(object sender, System.EventArgs e) {
            ChangeLang dlg = new ChangeLang();
            //dlg.Language = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                if (dlg.ChangeCurrentThreadLanguage) {
                    System.Globalization.FormLanguageSwitchSingleton.Instance.ChangeCurrentThreadUICulture(dlg.CultureInfo);
                    System.Globalization.FormLanguageSwitchSingleton.Instance.ChangeLanguage(this);
                }
                else
                    System.Globalization.FormLanguageSwitchSingleton.Instance.ChangeLanguage(this, dlg.CultureInfo);
            }
        }

        private void menuItem4_Click(object sender, System.EventArgs e) {
            FormChild newMDIChild = new FormChild();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
	}
}
