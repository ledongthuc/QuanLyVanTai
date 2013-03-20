using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TestMDIApp
{
	/// <summary>
	/// Summary description for ChildForm.
	/// </summary>
	public class FormChild : System.Windows.Forms.Form
	{
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MainMenu mainMenuChild;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormChild()
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
				if(components != null)
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormChild));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.mainMenuChild = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.AccessibleDescription = ((string)(resources.GetObject("richTextBox1.AccessibleDescription")));
            this.richTextBox1.AccessibleName = ((string)(resources.GetObject("richTextBox1.AccessibleName")));
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("richTextBox1.Anchor")));
            this.richTextBox1.AutoSize = ((bool)(resources.GetObject("richTextBox1.AutoSize")));
            this.richTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("richTextBox1.BackgroundImage")));
            this.richTextBox1.BulletIndent = ((int)(resources.GetObject("richTextBox1.BulletIndent")));
            this.richTextBox1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("richTextBox1.Dock")));
            this.richTextBox1.Enabled = ((bool)(resources.GetObject("richTextBox1.Enabled")));
            this.richTextBox1.Font = ((System.Drawing.Font)(resources.GetObject("richTextBox1.Font")));
            this.richTextBox1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("richTextBox1.ImeMode")));
            this.richTextBox1.Location = ((System.Drawing.Point)(resources.GetObject("richTextBox1.Location")));
            this.richTextBox1.MaxLength = ((int)(resources.GetObject("richTextBox1.MaxLength")));
            this.richTextBox1.Multiline = ((bool)(resources.GetObject("richTextBox1.Multiline")));
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightMargin = ((int)(resources.GetObject("richTextBox1.RightMargin")));
            this.richTextBox1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("richTextBox1.RightToLeft")));
            this.richTextBox1.ScrollBars = ((System.Windows.Forms.RichTextBoxScrollBars)(resources.GetObject("richTextBox1.ScrollBars")));
            this.richTextBox1.Size = ((System.Drawing.Size)(resources.GetObject("richTextBox1.Size")));
            this.richTextBox1.TabIndex = ((int)(resources.GetObject("richTextBox1.TabIndex")));
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.Visible = ((bool)(resources.GetObject("richTextBox1.Visible")));
            this.richTextBox1.WordWrap = ((bool)(resources.GetObject("richTextBox1.WordWrap")));
            this.richTextBox1.ZoomFactor = ((System.Single)(resources.GetObject("richTextBox1.ZoomFactor")));
            // 
            // mainMenuChild
            // 
            this.mainMenuChild.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                          this.menuItem1});
            this.mainMenuChild.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("mainMenuChild.RightToLeft")));
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
            // FormChild
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
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.richTextBox1});
            this.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("$this.Dock")));
            this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
            this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
            this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
            this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
            this.Menu = this.mainMenuChild;
            this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
            this.Name = "FormChild";
            this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
            this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
            this.Text = resources.GetString("$this.Text");
            this.Visible = ((bool)(resources.GetObject("$this.Visible")));
            this.ResumeLayout(false);

        }
		#endregion
	}
}
