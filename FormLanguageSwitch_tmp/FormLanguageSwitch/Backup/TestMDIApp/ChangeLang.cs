using System;
using System.Drawing;
using System.Collections;
using System.Globalization;
using System.ComponentModel;
using System.Windows.Forms;

namespace TestMDIApp
{
	/// <summary>
	/// Summary description for ChangeLang.
	/// </summary>
	public class ChangeLang : System.Windows.Forms.Form
	{
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox checkBox;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ChangeLang() {
			InitializeComponent();
            LanguageCollector lc = new LanguageCollector();
            //LanguageCollector lc = new LanguageCollector(CultureInfo.CurrentUICulture);
            int currentLanguage;
            CultureInfoDisplayItem[] lis = lc.GetLanguages(System.Globalization.LanguageCollector.LanguageNameDisplay.NativeName, out currentLanguage);
            comboBox.Items.AddRange(lis);
            comboBox.SelectedIndex = currentLanguage;
		}

        public CultureInfo CultureInfo {
            get { return ((CultureInfoDisplayItem)comboBox.SelectedItem).CultureInfo; }
            //set { comboBox.SelectedItem = value; }
        }

        public bool ChangeCurrentThreadLanguage {
            get { return checkBox.Checked; }
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ChangeLang));
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.AccessibleDescription = ((string)(resources.GetObject("comboBox.AccessibleDescription")));
            this.comboBox.AccessibleName = ((string)(resources.GetObject("comboBox.AccessibleName")));
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("comboBox.Anchor")));
            this.comboBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comboBox.BackgroundImage")));
            this.comboBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("comboBox.Dock")));
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Enabled = ((bool)(resources.GetObject("comboBox.Enabled")));
            this.comboBox.Font = ((System.Drawing.Font)(resources.GetObject("comboBox.Font")));
            this.comboBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("comboBox.ImeMode")));
            this.comboBox.IntegralHeight = ((bool)(resources.GetObject("comboBox.IntegralHeight")));
            this.comboBox.ItemHeight = ((int)(resources.GetObject("comboBox.ItemHeight")));
            this.comboBox.Location = ((System.Drawing.Point)(resources.GetObject("comboBox.Location")));
            this.comboBox.MaxDropDownItems = ((int)(resources.GetObject("comboBox.MaxDropDownItems")));
            this.comboBox.MaxLength = ((int)(resources.GetObject("comboBox.MaxLength")));
            this.comboBox.Name = "comboBox";
            this.comboBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("comboBox.RightToLeft")));
            this.comboBox.Size = ((System.Drawing.Size)(resources.GetObject("comboBox.Size")));
            this.comboBox.TabIndex = ((int)(resources.GetObject("comboBox.TabIndex")));
            this.comboBox.Text = resources.GetString("comboBox.Text");
            this.comboBox.Visible = ((bool)(resources.GetObject("comboBox.Visible")));
            // 
            // label
            // 
            this.label.AccessibleDescription = ((string)(resources.GetObject("label.AccessibleDescription")));
            this.label.AccessibleName = ((string)(resources.GetObject("label.AccessibleName")));
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label.Anchor")));
            this.label.AutoSize = ((bool)(resources.GetObject("label.AutoSize")));
            this.label.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label.Dock")));
            this.label.Enabled = ((bool)(resources.GetObject("label.Enabled")));
            this.label.Font = ((System.Drawing.Font)(resources.GetObject("label.Font")));
            this.label.Image = ((System.Drawing.Image)(resources.GetObject("label.Image")));
            this.label.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label.ImageAlign")));
            this.label.ImageIndex = ((int)(resources.GetObject("label.ImageIndex")));
            this.label.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label.ImeMode")));
            this.label.Location = ((System.Drawing.Point)(resources.GetObject("label.Location")));
            this.label.Name = "label";
            this.label.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label.RightToLeft")));
            this.label.Size = ((System.Drawing.Size)(resources.GetObject("label.Size")));
            this.label.TabIndex = ((int)(resources.GetObject("label.TabIndex")));
            this.label.Text = resources.GetString("label.Text");
            this.label.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label.TextAlign")));
            this.label.Visible = ((bool)(resources.GetObject("label.Visible")));
            // 
            // buttonOK
            // 
            this.buttonOK.AccessibleDescription = ((string)(resources.GetObject("buttonOK.AccessibleDescription")));
            this.buttonOK.AccessibleName = ((string)(resources.GetObject("buttonOK.AccessibleName")));
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("buttonOK.Anchor")));
            this.buttonOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOK.BackgroundImage")));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("buttonOK.Dock")));
            this.buttonOK.Enabled = ((bool)(resources.GetObject("buttonOK.Enabled")));
            this.buttonOK.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("buttonOK.FlatStyle")));
            this.buttonOK.Font = ((System.Drawing.Font)(resources.GetObject("buttonOK.Font")));
            this.buttonOK.Image = ((System.Drawing.Image)(resources.GetObject("buttonOK.Image")));
            this.buttonOK.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonOK.ImageAlign")));
            this.buttonOK.ImageIndex = ((int)(resources.GetObject("buttonOK.ImageIndex")));
            this.buttonOK.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("buttonOK.ImeMode")));
            this.buttonOK.Location = ((System.Drawing.Point)(resources.GetObject("buttonOK.Location")));
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("buttonOK.RightToLeft")));
            this.buttonOK.Size = ((System.Drawing.Size)(resources.GetObject("buttonOK.Size")));
            this.buttonOK.TabIndex = ((int)(resources.GetObject("buttonOK.TabIndex")));
            this.buttonOK.Text = resources.GetString("buttonOK.Text");
            this.buttonOK.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonOK.TextAlign")));
            this.buttonOK.Visible = ((bool)(resources.GetObject("buttonOK.Visible")));
            // 
            // buttonCancel
            // 
            this.buttonCancel.AccessibleDescription = ((string)(resources.GetObject("buttonCancel.AccessibleDescription")));
            this.buttonCancel.AccessibleName = ((string)(resources.GetObject("buttonCancel.AccessibleName")));
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("buttonCancel.Anchor")));
            this.buttonCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancel.BackgroundImage")));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("buttonCancel.Dock")));
            this.buttonCancel.Enabled = ((bool)(resources.GetObject("buttonCancel.Enabled")));
            this.buttonCancel.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("buttonCancel.FlatStyle")));
            this.buttonCancel.Font = ((System.Drawing.Font)(resources.GetObject("buttonCancel.Font")));
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonCancel.ImageAlign")));
            this.buttonCancel.ImageIndex = ((int)(resources.GetObject("buttonCancel.ImageIndex")));
            this.buttonCancel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("buttonCancel.ImeMode")));
            this.buttonCancel.Location = ((System.Drawing.Point)(resources.GetObject("buttonCancel.Location")));
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("buttonCancel.RightToLeft")));
            this.buttonCancel.Size = ((System.Drawing.Size)(resources.GetObject("buttonCancel.Size")));
            this.buttonCancel.TabIndex = ((int)(resources.GetObject("buttonCancel.TabIndex")));
            this.buttonCancel.Text = resources.GetString("buttonCancel.Text");
            this.buttonCancel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonCancel.TextAlign")));
            this.buttonCancel.Visible = ((bool)(resources.GetObject("buttonCancel.Visible")));
            // 
            // checkBox
            // 
            this.checkBox.AccessibleDescription = ((string)(resources.GetObject("checkBox.AccessibleDescription")));
            this.checkBox.AccessibleName = ((string)(resources.GetObject("checkBox.AccessibleName")));
            this.checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("checkBox.Anchor")));
            this.checkBox.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("checkBox.Appearance")));
            this.checkBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox.BackgroundImage")));
            this.checkBox.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox.CheckAlign")));
            this.checkBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("checkBox.Dock")));
            this.checkBox.Enabled = ((bool)(resources.GetObject("checkBox.Enabled")));
            this.checkBox.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("checkBox.FlatStyle")));
            this.checkBox.Font = ((System.Drawing.Font)(resources.GetObject("checkBox.Font")));
            this.checkBox.Image = ((System.Drawing.Image)(resources.GetObject("checkBox.Image")));
            this.checkBox.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox.ImageAlign")));
            this.checkBox.ImageIndex = ((int)(resources.GetObject("checkBox.ImageIndex")));
            this.checkBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("checkBox.ImeMode")));
            this.checkBox.Location = ((System.Drawing.Point)(resources.GetObject("checkBox.Location")));
            this.checkBox.Name = "checkBox";
            this.checkBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("checkBox.RightToLeft")));
            this.checkBox.Size = ((System.Drawing.Size)(resources.GetObject("checkBox.Size")));
            this.checkBox.TabIndex = ((int)(resources.GetObject("checkBox.TabIndex")));
            this.checkBox.Text = resources.GetString("checkBox.Text");
            this.checkBox.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox.TextAlign")));
            this.checkBox.Visible = ((bool)(resources.GetObject("checkBox.Visible")));
            // 
            // ChangeLang
            // 
            this.AcceptButton = this.buttonOK;
            this.AccessibleDescription = ((string)(resources.GetObject("$this.AccessibleDescription")));
            this.AccessibleName = ((string)(resources.GetObject("$this.AccessibleName")));
            this.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("$this.Anchor")));
            this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
            this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
            this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
            this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.buttonCancel;
            this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.checkBox,
                                                                          this.buttonCancel,
                                                                          this.buttonOK,
                                                                          this.label,
                                                                          this.comboBox});
            this.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("$this.Dock")));
            this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
            this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
            this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
            this.MaximizeBox = false;
            this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
            this.MinimizeBox = false;
            this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
            this.Name = "ChangeLang";
            this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
            this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
            this.Text = resources.GetString("$this.Text");
            this.Visible = ((bool)(resources.GetObject("$this.Visible")));
            this.ResumeLayout(false);

        }
		#endregion
	}
}
