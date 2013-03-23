using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace ResourceChange
{
	/// <summary>
	/// Summary description for UserControl.
	/// </summary>
	public class TestUserControl : System.Windows.Forms.UserControl
	{
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ToolTip toolTip;
        private System.ComponentModel.IContainer components;

		public TestUserControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TestUserControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = ((string)(resources.GetObject("groupBox1.AccessibleDescription")));
            this.groupBox1.AccessibleName = ((string)(resources.GetObject("groupBox1.AccessibleName")));
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox1.Anchor")));
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                    this.radioButton2,
                                                                                    this.radioButton1});
            this.groupBox1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox1.Dock")));
            this.groupBox1.Enabled = ((bool)(resources.GetObject("groupBox1.Enabled")));
            this.groupBox1.Font = ((System.Drawing.Font)(resources.GetObject("groupBox1.Font")));
            this.groupBox1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox1.ImeMode")));
            this.groupBox1.Location = ((System.Drawing.Point)(resources.GetObject("groupBox1.Location")));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox1.RightToLeft")));
            this.groupBox1.Size = ((System.Drawing.Size)(resources.GetObject("groupBox1.Size")));
            this.groupBox1.TabIndex = ((int)(resources.GetObject("groupBox1.TabIndex")));
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = resources.GetString("groupBox1.Text");
            this.toolTip.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            this.groupBox1.Visible = ((bool)(resources.GetObject("groupBox1.Visible")));
            // 
            // radioButton2
            // 
            this.radioButton2.AccessibleDescription = ((string)(resources.GetObject("radioButton2.AccessibleDescription")));
            this.radioButton2.AccessibleName = ((string)(resources.GetObject("radioButton2.AccessibleName")));
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("radioButton2.Anchor")));
            this.radioButton2.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("radioButton2.Appearance")));
            this.radioButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton2.BackgroundImage")));
            this.radioButton2.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton2.CheckAlign")));
            this.radioButton2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("radioButton2.Dock")));
            this.radioButton2.Enabled = ((bool)(resources.GetObject("radioButton2.Enabled")));
            this.radioButton2.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("radioButton2.FlatStyle")));
            this.radioButton2.Font = ((System.Drawing.Font)(resources.GetObject("radioButton2.Font")));
            this.radioButton2.Image = ((System.Drawing.Image)(resources.GetObject("radioButton2.Image")));
            this.radioButton2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton2.ImageAlign")));
            this.radioButton2.ImageIndex = ((int)(resources.GetObject("radioButton2.ImageIndex")));
            this.radioButton2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radioButton2.ImeMode")));
            this.radioButton2.Location = ((System.Drawing.Point)(resources.GetObject("radioButton2.Location")));
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("radioButton2.RightToLeft")));
            this.radioButton2.Size = ((System.Drawing.Size)(resources.GetObject("radioButton2.Size")));
            this.radioButton2.TabIndex = ((int)(resources.GetObject("radioButton2.TabIndex")));
            this.radioButton2.Text = resources.GetString("radioButton2.Text");
            this.radioButton2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton2.TextAlign")));
            this.toolTip.SetToolTip(this.radioButton2, resources.GetString("radioButton2.ToolTip"));
            this.radioButton2.Visible = ((bool)(resources.GetObject("radioButton2.Visible")));
            // 
            // radioButton1
            // 
            this.radioButton1.AccessibleDescription = ((string)(resources.GetObject("radioButton1.AccessibleDescription")));
            this.radioButton1.AccessibleName = ((string)(resources.GetObject("radioButton1.AccessibleName")));
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("radioButton1.Anchor")));
            this.radioButton1.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("radioButton1.Appearance")));
            this.radioButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton1.BackgroundImage")));
            this.radioButton1.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton1.CheckAlign")));
            this.radioButton1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("radioButton1.Dock")));
            this.radioButton1.Enabled = ((bool)(resources.GetObject("radioButton1.Enabled")));
            this.radioButton1.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("radioButton1.FlatStyle")));
            this.radioButton1.Font = ((System.Drawing.Font)(resources.GetObject("radioButton1.Font")));
            this.radioButton1.Image = ((System.Drawing.Image)(resources.GetObject("radioButton1.Image")));
            this.radioButton1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton1.ImageAlign")));
            this.radioButton1.ImageIndex = ((int)(resources.GetObject("radioButton1.ImageIndex")));
            this.radioButton1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radioButton1.ImeMode")));
            this.radioButton1.Location = ((System.Drawing.Point)(resources.GetObject("radioButton1.Location")));
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("radioButton1.RightToLeft")));
            this.radioButton1.Size = ((System.Drawing.Size)(resources.GetObject("radioButton1.Size")));
            this.radioButton1.TabIndex = ((int)(resources.GetObject("radioButton1.TabIndex")));
            this.radioButton1.Text = resources.GetString("radioButton1.Text");
            this.radioButton1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButton1.TextAlign")));
            this.toolTip.SetToolTip(this.radioButton1, resources.GetString("radioButton1.ToolTip"));
            this.radioButton1.Visible = ((bool)(resources.GetObject("radioButton1.Visible")));
            // 
            // TestUserControl
            // 
            this.AccessibleDescription = ((string)(resources.GetObject("$this.AccessibleDescription")));
            this.AccessibleName = ((string)(resources.GetObject("$this.AccessibleName")));
            this.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("$this.Anchor")));
            this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
            this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
            this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.groupBox1});
            this.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("$this.Dock")));
            this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
            this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
            this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
            this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
            this.Name = "TestUserControl";
            this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
            this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
            this.TabIndex = ((int)(resources.GetObject("$this.TabIndex")));
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Visible = ((bool)(resources.GetObject("$this.Visible")));
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
		#endregion
	}
}
