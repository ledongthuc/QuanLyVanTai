using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Data;

namespace ChangeLanguage
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FormMain : System.Windows.Forms.Form
	{
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel2;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.GroupBox groupBox;
        private ResourceChange.TestUserControl testUserControl;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ToolBar toolBar;
        private System.Windows.Forms.ToolBarButton toolBarButton1;
        private System.Windows.Forms.ContextMenu contextMenuListView;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.ContextMenu contextMenuLanguage;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageListToolbar;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Button buttonApplyLanguage;
        private System.ComponentModel.IContainer components;

		public FormMain() {
            InitializeComponent();
            LanguageCollector lc = new LanguageCollector();
            //LanguageCollector lc = new LanguageCollector(CultureInfo.CurrentUICulture);
            int currentLanguage;
            CultureInfoDisplayItem[] lis = lc.GetLanguages(System.Globalization.LanguageCollector.LanguageNameDisplay.NativeName, out currentLanguage);
            comboBoxLanguage.Items.AddRange(lis);
            this.comboBoxLanguage.SelectedIndex = currentLanguage;
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
            this.components = new System.ComponentModel.Container();
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormMain));
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.contextMenuLanguage = new System.Windows.Forms.ContextMenu();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.label = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.testUserControl = new ResourceChange.TestUserControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuListView = new System.Windows.Forms.ContextMenu();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buttonApplyLanguage = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolBar = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.imageListToolbar = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.AccessibleDescription = ((string)(resources.GetObject("comboBoxLanguage.AccessibleDescription")));
            this.comboBoxLanguage.AccessibleName = ((string)(resources.GetObject("comboBoxLanguage.AccessibleName")));
            this.comboBoxLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("comboBoxLanguage.Anchor")));
            this.comboBoxLanguage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comboBoxLanguage.BackgroundImage")));
            this.comboBoxLanguage.ContextMenu = this.contextMenuLanguage;
            this.comboBoxLanguage.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("comboBoxLanguage.Dock")));
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.Enabled = ((bool)(resources.GetObject("comboBoxLanguage.Enabled")));
            this.comboBoxLanguage.Font = ((System.Drawing.Font)(resources.GetObject("comboBoxLanguage.Font")));
            this.comboBoxLanguage.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("comboBoxLanguage.ImeMode")));
            this.comboBoxLanguage.IntegralHeight = ((bool)(resources.GetObject("comboBoxLanguage.IntegralHeight")));
            this.comboBoxLanguage.ItemHeight = ((int)(resources.GetObject("comboBoxLanguage.ItemHeight")));
            this.comboBoxLanguage.Location = ((System.Drawing.Point)(resources.GetObject("comboBoxLanguage.Location")));
            this.comboBoxLanguage.MaxDropDownItems = ((int)(resources.GetObject("comboBoxLanguage.MaxDropDownItems")));
            this.comboBoxLanguage.MaxLength = ((int)(resources.GetObject("comboBoxLanguage.MaxLength")));
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("comboBoxLanguage.RightToLeft")));
            this.comboBoxLanguage.Size = ((System.Drawing.Size)(resources.GetObject("comboBoxLanguage.Size")));
            this.comboBoxLanguage.TabIndex = ((int)(resources.GetObject("comboBoxLanguage.TabIndex")));
            this.comboBoxLanguage.Text = resources.GetString("comboBoxLanguage.Text");
            this.toolTip.SetToolTip(this.comboBoxLanguage, resources.GetString("comboBoxLanguage.ToolTip"));
            this.comboBoxLanguage.Visible = ((bool)(resources.GetObject("comboBoxLanguage.Visible")));
            // 
            // contextMenuLanguage
            // 
            this.contextMenuLanguage.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                                this.menuItem4});
            this.contextMenuLanguage.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("contextMenuLanguage.RightToLeft")));
            // 
            // menuItem4
            // 
            this.menuItem4.Enabled = ((bool)(resources.GetObject("menuItem4.Enabled")));
            this.menuItem4.Index = 0;
            this.menuItem4.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItem4.Shortcut")));
            this.menuItem4.ShowShortcut = ((bool)(resources.GetObject("menuItem4.ShowShortcut")));
            this.menuItem4.Text = resources.GetString("menuItem4.Text");
            this.menuItem4.Visible = ((bool)(resources.GetObject("menuItem4.Visible")));
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
            this.toolTip.SetToolTip(this.label, resources.GetString("label.ToolTip"));
            this.label.Visible = ((bool)(resources.GetObject("label.Visible")));
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                     this.menuItem1});
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
            // statusBar
            // 
            this.statusBar.AccessibleDescription = ((string)(resources.GetObject("statusBar.AccessibleDescription")));
            this.statusBar.AccessibleName = ((string)(resources.GetObject("statusBar.AccessibleName")));
            this.statusBar.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("statusBar.Anchor")));
            this.statusBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusBar.BackgroundImage")));
            this.statusBar.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("statusBar.Dock")));
            this.statusBar.Enabled = ((bool)(resources.GetObject("statusBar.Enabled")));
            this.statusBar.Font = ((System.Drawing.Font)(resources.GetObject("statusBar.Font")));
            this.statusBar.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("statusBar.ImeMode")));
            this.statusBar.Location = ((System.Drawing.Point)(resources.GetObject("statusBar.Location")));
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
                                                                                         this.statusBarPanel1,
                                                                                         this.statusBarPanel2});
            this.statusBar.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("statusBar.RightToLeft")));
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = ((System.Drawing.Size)(resources.GetObject("statusBar.Size")));
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = ((int)(resources.GetObject("statusBar.TabIndex")));
            this.statusBar.Text = resources.GetString("statusBar.Text");
            this.toolTip.SetToolTip(this.statusBar, resources.GetString("statusBar.ToolTip"));
            this.statusBar.Visible = ((bool)(resources.GetObject("statusBar.Visible")));
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Alignment = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("statusBarPanel1.Alignment")));
            this.statusBarPanel1.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanel1.Icon")));
            this.statusBarPanel1.MinWidth = ((int)(resources.GetObject("statusBarPanel1.MinWidth")));
            this.statusBarPanel1.Text = resources.GetString("statusBarPanel1.Text");
            this.statusBarPanel1.ToolTipText = resources.GetString("statusBarPanel1.ToolTipText");
            this.statusBarPanel1.Width = ((int)(resources.GetObject("statusBarPanel1.Width")));
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Alignment = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("statusBarPanel2.Alignment")));
            this.statusBarPanel2.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanel2.Icon")));
            this.statusBarPanel2.MinWidth = ((int)(resources.GetObject("statusBarPanel2.MinWidth")));
            this.statusBarPanel2.Text = resources.GetString("statusBarPanel2.Text");
            this.statusBarPanel2.ToolTipText = resources.GetString("statusBarPanel2.ToolTipText");
            this.statusBarPanel2.Width = ((int)(resources.GetObject("statusBarPanel2.Width")));
            // 
            // tabControl
            // 
            this.tabControl.AccessibleDescription = ((string)(resources.GetObject("tabControl.AccessibleDescription")));
            this.tabControl.AccessibleName = ((string)(resources.GetObject("tabControl.AccessibleName")));
            this.tabControl.Alignment = ((System.Windows.Forms.TabAlignment)(resources.GetObject("tabControl.Alignment")));
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabControl.Anchor")));
            this.tabControl.Appearance = ((System.Windows.Forms.TabAppearance)(resources.GetObject("tabControl.Appearance")));
            this.tabControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabControl.BackgroundImage")));
            this.tabControl.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                     this.tabPage1,
                                                                                     this.tabPage2,
                                                                                     this.tabPage3,
                                                                                     this.tabPage4,
                                                                                     this.tabPage5});
            this.tabControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabControl.Dock")));
            this.tabControl.Enabled = ((bool)(resources.GetObject("tabControl.Enabled")));
            this.tabControl.Font = ((System.Drawing.Font)(resources.GetObject("tabControl.Font")));
            this.tabControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabControl.ImeMode")));
            this.tabControl.ItemSize = ((System.Drawing.Size)(resources.GetObject("tabControl.ItemSize")));
            this.tabControl.Location = ((System.Drawing.Point)(resources.GetObject("tabControl.Location")));
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = ((System.Drawing.Point)(resources.GetObject("tabControl.Padding")));
            this.tabControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabControl.RightToLeft")));
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = ((bool)(resources.GetObject("tabControl.ShowToolTips")));
            this.tabControl.Size = ((System.Drawing.Size)(resources.GetObject("tabControl.Size")));
            this.tabControl.TabIndex = ((int)(resources.GetObject("tabControl.TabIndex")));
            this.tabControl.Text = resources.GetString("tabControl.Text");
            this.toolTip.SetToolTip(this.tabControl, resources.GetString("tabControl.ToolTip"));
            this.tabControl.Visible = ((bool)(resources.GetObject("tabControl.Visible")));
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleDescription = ((string)(resources.GetObject("tabPage1.AccessibleDescription")));
            this.tabPage1.AccessibleName = ((string)(resources.GetObject("tabPage1.AccessibleName")));
            this.tabPage1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage1.Anchor")));
            this.tabPage1.AutoScroll = ((bool)(resources.GetObject("tabPage1.AutoScroll")));
            this.tabPage1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage1.AutoScrollMargin")));
            this.tabPage1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage1.AutoScrollMinSize")));
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                   this.groupBox});
            this.tabPage1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage1.Dock")));
            this.tabPage1.Enabled = ((bool)(resources.GetObject("tabPage1.Enabled")));
            this.tabPage1.Font = ((System.Drawing.Font)(resources.GetObject("tabPage1.Font")));
            this.tabPage1.ImageIndex = ((int)(resources.GetObject("tabPage1.ImageIndex")));
            this.tabPage1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage1.ImeMode")));
            this.tabPage1.Location = ((System.Drawing.Point)(resources.GetObject("tabPage1.Location")));
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage1.RightToLeft")));
            this.tabPage1.Size = ((System.Drawing.Size)(resources.GetObject("tabPage1.Size")));
            this.tabPage1.TabIndex = ((int)(resources.GetObject("tabPage1.TabIndex")));
            this.tabPage1.Text = resources.GetString("tabPage1.Text");
            this.toolTip.SetToolTip(this.tabPage1, resources.GetString("tabPage1.ToolTip"));
            this.tabPage1.ToolTipText = resources.GetString("tabPage1.ToolTipText");
            this.tabPage1.Visible = ((bool)(resources.GetObject("tabPage1.Visible")));
            // 
            // groupBox
            // 
            this.groupBox.AccessibleDescription = ((string)(resources.GetObject("groupBox.AccessibleDescription")));
            this.groupBox.AccessibleName = ((string)(resources.GetObject("groupBox.AccessibleName")));
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox.Anchor")));
            this.groupBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox.BackgroundImage")));
            this.groupBox.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                   this.checkBox2,
                                                                                   this.checkBox1});
            this.groupBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox.Dock")));
            this.groupBox.Enabled = ((bool)(resources.GetObject("groupBox.Enabled")));
            this.groupBox.Font = ((System.Drawing.Font)(resources.GetObject("groupBox.Font")));
            this.groupBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox.ImeMode")));
            this.groupBox.Location = ((System.Drawing.Point)(resources.GetObject("groupBox.Location")));
            this.groupBox.Name = "groupBox";
            this.groupBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox.RightToLeft")));
            this.groupBox.Size = ((System.Drawing.Size)(resources.GetObject("groupBox.Size")));
            this.groupBox.TabIndex = ((int)(resources.GetObject("groupBox.TabIndex")));
            this.groupBox.TabStop = false;
            this.groupBox.Text = resources.GetString("groupBox.Text");
            this.toolTip.SetToolTip(this.groupBox, resources.GetString("groupBox.ToolTip"));
            this.groupBox.Visible = ((bool)(resources.GetObject("groupBox.Visible")));
            // 
            // checkBox2
            // 
            this.checkBox2.AccessibleDescription = ((string)(resources.GetObject("checkBox2.AccessibleDescription")));
            this.checkBox2.AccessibleName = ((string)(resources.GetObject("checkBox2.AccessibleName")));
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("checkBox2.Anchor")));
            this.checkBox2.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("checkBox2.Appearance")));
            this.checkBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox2.BackgroundImage")));
            this.checkBox2.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox2.CheckAlign")));
            this.checkBox2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("checkBox2.Dock")));
            this.checkBox2.Enabled = ((bool)(resources.GetObject("checkBox2.Enabled")));
            this.checkBox2.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("checkBox2.FlatStyle")));
            this.checkBox2.Font = ((System.Drawing.Font)(resources.GetObject("checkBox2.Font")));
            this.checkBox2.Image = ((System.Drawing.Image)(resources.GetObject("checkBox2.Image")));
            this.checkBox2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox2.ImageAlign")));
            this.checkBox2.ImageIndex = ((int)(resources.GetObject("checkBox2.ImageIndex")));
            this.checkBox2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("checkBox2.ImeMode")));
            this.checkBox2.Location = ((System.Drawing.Point)(resources.GetObject("checkBox2.Location")));
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("checkBox2.RightToLeft")));
            this.checkBox2.Size = ((System.Drawing.Size)(resources.GetObject("checkBox2.Size")));
            this.checkBox2.TabIndex = ((int)(resources.GetObject("checkBox2.TabIndex")));
            this.checkBox2.Text = resources.GetString("checkBox2.Text");
            this.checkBox2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox2.TextAlign")));
            this.toolTip.SetToolTip(this.checkBox2, resources.GetString("checkBox2.ToolTip"));
            this.checkBox2.Visible = ((bool)(resources.GetObject("checkBox2.Visible")));
            // 
            // checkBox1
            // 
            this.checkBox1.AccessibleDescription = ((string)(resources.GetObject("checkBox1.AccessibleDescription")));
            this.checkBox1.AccessibleName = ((string)(resources.GetObject("checkBox1.AccessibleName")));
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("checkBox1.Anchor")));
            this.checkBox1.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("checkBox1.Appearance")));
            this.checkBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox1.BackgroundImage")));
            this.checkBox1.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox1.CheckAlign")));
            this.checkBox1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("checkBox1.Dock")));
            this.checkBox1.Enabled = ((bool)(resources.GetObject("checkBox1.Enabled")));
            this.checkBox1.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("checkBox1.FlatStyle")));
            this.checkBox1.Font = ((System.Drawing.Font)(resources.GetObject("checkBox1.Font")));
            this.checkBox1.Image = ((System.Drawing.Image)(resources.GetObject("checkBox1.Image")));
            this.checkBox1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox1.ImageAlign")));
            this.checkBox1.ImageIndex = ((int)(resources.GetObject("checkBox1.ImageIndex")));
            this.checkBox1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("checkBox1.ImeMode")));
            this.checkBox1.Location = ((System.Drawing.Point)(resources.GetObject("checkBox1.Location")));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("checkBox1.RightToLeft")));
            this.checkBox1.Size = ((System.Drawing.Size)(resources.GetObject("checkBox1.Size")));
            this.checkBox1.TabIndex = ((int)(resources.GetObject("checkBox1.TabIndex")));
            this.checkBox1.Text = resources.GetString("checkBox1.Text");
            this.checkBox1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("checkBox1.TextAlign")));
            this.toolTip.SetToolTip(this.checkBox1, resources.GetString("checkBox1.ToolTip"));
            this.checkBox1.Visible = ((bool)(resources.GetObject("checkBox1.Visible")));
            // 
            // tabPage2
            // 
            this.tabPage2.AccessibleDescription = ((string)(resources.GetObject("tabPage2.AccessibleDescription")));
            this.tabPage2.AccessibleName = ((string)(resources.GetObject("tabPage2.AccessibleName")));
            this.tabPage2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage2.Anchor")));
            this.tabPage2.AutoScroll = ((bool)(resources.GetObject("tabPage2.AutoScroll")));
            this.tabPage2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage2.AutoScrollMargin")));
            this.tabPage2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage2.AutoScrollMinSize")));
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                   this.testUserControl});
            this.tabPage2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage2.Dock")));
            this.tabPage2.Enabled = ((bool)(resources.GetObject("tabPage2.Enabled")));
            this.tabPage2.Font = ((System.Drawing.Font)(resources.GetObject("tabPage2.Font")));
            this.tabPage2.ImageIndex = ((int)(resources.GetObject("tabPage2.ImageIndex")));
            this.tabPage2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage2.ImeMode")));
            this.tabPage2.Location = ((System.Drawing.Point)(resources.GetObject("tabPage2.Location")));
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage2.RightToLeft")));
            this.tabPage2.Size = ((System.Drawing.Size)(resources.GetObject("tabPage2.Size")));
            this.tabPage2.TabIndex = ((int)(resources.GetObject("tabPage2.TabIndex")));
            this.tabPage2.Text = resources.GetString("tabPage2.Text");
            this.toolTip.SetToolTip(this.tabPage2, resources.GetString("tabPage2.ToolTip"));
            this.tabPage2.ToolTipText = resources.GetString("tabPage2.ToolTipText");
            this.tabPage2.Visible = ((bool)(resources.GetObject("tabPage2.Visible")));
            // 
            // testUserControl
            // 
            this.testUserControl.AccessibleDescription = ((string)(resources.GetObject("testUserControl.AccessibleDescription")));
            this.testUserControl.AccessibleName = ((string)(resources.GetObject("testUserControl.AccessibleName")));
            this.testUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("testUserControl.Anchor")));
            this.testUserControl.AutoScroll = ((bool)(resources.GetObject("testUserControl.AutoScroll")));
            this.testUserControl.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("testUserControl.AutoScrollMargin")));
            this.testUserControl.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("testUserControl.AutoScrollMinSize")));
            this.testUserControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("testUserControl.BackgroundImage")));
            this.testUserControl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("testUserControl.Dock")));
            this.testUserControl.Enabled = ((bool)(resources.GetObject("testUserControl.Enabled")));
            this.testUserControl.Font = ((System.Drawing.Font)(resources.GetObject("testUserControl.Font")));
            this.testUserControl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("testUserControl.ImeMode")));
            this.testUserControl.Location = ((System.Drawing.Point)(resources.GetObject("testUserControl.Location")));
            this.testUserControl.Name = "testUserControl";
            this.testUserControl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("testUserControl.RightToLeft")));
            this.testUserControl.Size = ((System.Drawing.Size)(resources.GetObject("testUserControl.Size")));
            this.testUserControl.TabIndex = ((int)(resources.GetObject("testUserControl.TabIndex")));
            this.toolTip.SetToolTip(this.testUserControl, resources.GetString("testUserControl.ToolTip"));
            this.testUserControl.Visible = ((bool)(resources.GetObject("testUserControl.Visible")));
            // 
            // tabPage3
            // 
            this.tabPage3.AccessibleDescription = ((string)(resources.GetObject("tabPage3.AccessibleDescription")));
            this.tabPage3.AccessibleName = ((string)(resources.GetObject("tabPage3.AccessibleName")));
            this.tabPage3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage3.Anchor")));
            this.tabPage3.AutoScroll = ((bool)(resources.GetObject("tabPage3.AutoScroll")));
            this.tabPage3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage3.AutoScrollMargin")));
            this.tabPage3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage3.AutoScrollMinSize")));
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                   this.listBox});
            this.tabPage3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage3.Dock")));
            this.tabPage3.Enabled = ((bool)(resources.GetObject("tabPage3.Enabled")));
            this.tabPage3.Font = ((System.Drawing.Font)(resources.GetObject("tabPage3.Font")));
            this.tabPage3.ImageIndex = ((int)(resources.GetObject("tabPage3.ImageIndex")));
            this.tabPage3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage3.ImeMode")));
            this.tabPage3.Location = ((System.Drawing.Point)(resources.GetObject("tabPage3.Location")));
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage3.RightToLeft")));
            this.tabPage3.Size = ((System.Drawing.Size)(resources.GetObject("tabPage3.Size")));
            this.tabPage3.TabIndex = ((int)(resources.GetObject("tabPage3.TabIndex")));
            this.tabPage3.Text = resources.GetString("tabPage3.Text");
            this.toolTip.SetToolTip(this.tabPage3, resources.GetString("tabPage3.ToolTip"));
            this.tabPage3.ToolTipText = resources.GetString("tabPage3.ToolTipText");
            this.tabPage3.Visible = ((bool)(resources.GetObject("tabPage3.Visible")));
            // 
            // listBox
            // 
            this.listBox.AccessibleDescription = ((string)(resources.GetObject("listBox.AccessibleDescription")));
            this.listBox.AccessibleName = ((string)(resources.GetObject("listBox.AccessibleName")));
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("listBox.Anchor")));
            this.listBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listBox.BackgroundImage")));
            this.listBox.ColumnWidth = ((int)(resources.GetObject("listBox.ColumnWidth")));
            this.listBox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("listBox.Dock")));
            this.listBox.Enabled = ((bool)(resources.GetObject("listBox.Enabled")));
            this.listBox.Font = ((System.Drawing.Font)(resources.GetObject("listBox.Font")));
            this.listBox.HorizontalExtent = ((int)(resources.GetObject("listBox.HorizontalExtent")));
            this.listBox.HorizontalScrollbar = ((bool)(resources.GetObject("listBox.HorizontalScrollbar")));
            this.listBox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("listBox.ImeMode")));
            this.listBox.IntegralHeight = ((bool)(resources.GetObject("listBox.IntegralHeight")));
            this.listBox.ItemHeight = ((int)(resources.GetObject("listBox.ItemHeight")));
            this.listBox.Items.AddRange(new object[] {
                                                         resources.GetString("listBox.Items.Items"),
                                                         resources.GetString("listBox.Items.Items1"),
                                                         resources.GetString("listBox.Items.Items2")});
            this.listBox.Location = ((System.Drawing.Point)(resources.GetObject("listBox.Location")));
            this.listBox.Name = "listBox";
            this.listBox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("listBox.RightToLeft")));
            this.listBox.ScrollAlwaysVisible = ((bool)(resources.GetObject("listBox.ScrollAlwaysVisible")));
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox.Size = ((System.Drawing.Size)(resources.GetObject("listBox.Size")));
            this.listBox.TabIndex = ((int)(resources.GetObject("listBox.TabIndex")));
            this.toolTip.SetToolTip(this.listBox, resources.GetString("listBox.ToolTip"));
            this.listBox.Visible = ((bool)(resources.GetObject("listBox.Visible")));
            // 
            // tabPage4
            // 
            this.tabPage4.AccessibleDescription = ((string)(resources.GetObject("tabPage4.AccessibleDescription")));
            this.tabPage4.AccessibleName = ((string)(resources.GetObject("tabPage4.AccessibleName")));
            this.tabPage4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage4.Anchor")));
            this.tabPage4.AutoScroll = ((bool)(resources.GetObject("tabPage4.AutoScroll")));
            this.tabPage4.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage4.AutoScrollMargin")));
            this.tabPage4.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage4.AutoScrollMinSize")));
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                   this.listView});
            this.tabPage4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage4.Dock")));
            this.tabPage4.Enabled = ((bool)(resources.GetObject("tabPage4.Enabled")));
            this.tabPage4.Font = ((System.Drawing.Font)(resources.GetObject("tabPage4.Font")));
            this.tabPage4.ImageIndex = ((int)(resources.GetObject("tabPage4.ImageIndex")));
            this.tabPage4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage4.ImeMode")));
            this.tabPage4.Location = ((System.Drawing.Point)(resources.GetObject("tabPage4.Location")));
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage4.RightToLeft")));
            this.tabPage4.Size = ((System.Drawing.Size)(resources.GetObject("tabPage4.Size")));
            this.tabPage4.TabIndex = ((int)(resources.GetObject("tabPage4.TabIndex")));
            this.tabPage4.Text = resources.GetString("tabPage4.Text");
            this.toolTip.SetToolTip(this.tabPage4, resources.GetString("tabPage4.ToolTip"));
            this.tabPage4.ToolTipText = resources.GetString("tabPage4.ToolTipText");
            this.tabPage4.Visible = ((bool)(resources.GetObject("tabPage4.Visible")));
            // 
            // listView
            // 
            this.listView.AccessibleDescription = ((string)(resources.GetObject("listView.AccessibleDescription")));
            this.listView.AccessibleName = ((string)(resources.GetObject("listView.AccessibleName")));
            this.listView.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("listView.Alignment")));
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("listView.Anchor")));
            this.listView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView.BackgroundImage")));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                                                                       this.columnHeader1,
                                                                                       this.columnHeader2});
            this.listView.ContextMenu = this.contextMenuListView;
            this.listView.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("listView.Dock")));
            this.listView.Enabled = ((bool)(resources.GetObject("listView.Enabled")));
            this.listView.Font = ((System.Drawing.Font)(resources.GetObject("listView.Font")));
            this.listView.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("listView.ImeMode")));
            this.listView.LabelWrap = ((bool)(resources.GetObject("listView.LabelWrap")));
            this.listView.Location = ((System.Drawing.Point)(resources.GetObject("listView.Location")));
            this.listView.Name = "listView";
            this.listView.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("listView.RightToLeft")));
            this.listView.Size = ((System.Drawing.Size)(resources.GetObject("listView.Size")));
            this.listView.TabIndex = ((int)(resources.GetObject("listView.TabIndex")));
            this.listView.Text = resources.GetString("listView.Text");
            this.toolTip.SetToolTip(this.listView, resources.GetString("listView.ToolTip"));
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.Visible = ((bool)(resources.GetObject("listView.Visible")));
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = resources.GetString("columnHeader1.Text");
            this.columnHeader1.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader1.TextAlign")));
            this.columnHeader1.Width = ((int)(resources.GetObject("columnHeader1.Width")));
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = resources.GetString("columnHeader2.Text");
            this.columnHeader2.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader2.TextAlign")));
            this.columnHeader2.Width = ((int)(resources.GetObject("columnHeader2.Width")));
            // 
            // contextMenuListView
            // 
            this.contextMenuListView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                                this.menuItem3});
            this.contextMenuListView.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("contextMenuListView.RightToLeft")));
            // 
            // menuItem3
            // 
            this.menuItem3.Enabled = ((bool)(resources.GetObject("menuItem3.Enabled")));
            this.menuItem3.Index = 0;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                      this.menuItem5});
            this.menuItem3.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItem3.Shortcut")));
            this.menuItem3.ShowShortcut = ((bool)(resources.GetObject("menuItem3.ShowShortcut")));
            this.menuItem3.Text = resources.GetString("menuItem3.Text");
            this.menuItem3.Visible = ((bool)(resources.GetObject("menuItem3.Visible")));
            // 
            // menuItem5
            // 
            this.menuItem5.Enabled = ((bool)(resources.GetObject("menuItem5.Enabled")));
            this.menuItem5.Index = 0;
            this.menuItem5.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItem5.Shortcut")));
            this.menuItem5.ShowShortcut = ((bool)(resources.GetObject("menuItem5.ShowShortcut")));
            this.menuItem5.Text = resources.GetString("menuItem5.Text");
            this.menuItem5.Visible = ((bool)(resources.GetObject("menuItem5.Visible")));
            // 
            // tabPage5
            // 
            this.tabPage5.AccessibleDescription = ((string)(resources.GetObject("tabPage5.AccessibleDescription")));
            this.tabPage5.AccessibleName = ((string)(resources.GetObject("tabPage5.AccessibleName")));
            this.tabPage5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage5.Anchor")));
            this.tabPage5.AutoScroll = ((bool)(resources.GetObject("tabPage5.AutoScroll")));
            this.tabPage5.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage5.AutoScrollMargin")));
            this.tabPage5.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage5.AutoScrollMinSize")));
            this.tabPage5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage5.BackgroundImage")));
            this.tabPage5.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                   this.treeView1});
            this.tabPage5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage5.Dock")));
            this.tabPage5.Enabled = ((bool)(resources.GetObject("tabPage5.Enabled")));
            this.tabPage5.Font = ((System.Drawing.Font)(resources.GetObject("tabPage5.Font")));
            this.tabPage5.ImageIndex = ((int)(resources.GetObject("tabPage5.ImageIndex")));
            this.tabPage5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage5.ImeMode")));
            this.tabPage5.Location = ((System.Drawing.Point)(resources.GetObject("tabPage5.Location")));
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage5.RightToLeft")));
            this.tabPage5.Size = ((System.Drawing.Size)(resources.GetObject("tabPage5.Size")));
            this.tabPage5.TabIndex = ((int)(resources.GetObject("tabPage5.TabIndex")));
            this.tabPage5.Text = resources.GetString("tabPage5.Text");
            this.toolTip.SetToolTip(this.tabPage5, resources.GetString("tabPage5.ToolTip"));
            this.tabPage5.ToolTipText = resources.GetString("tabPage5.ToolTipText");
            this.tabPage5.Visible = ((bool)(resources.GetObject("tabPage5.Visible")));
            // 
            // treeView1
            // 
            this.treeView1.AccessibleDescription = ((string)(resources.GetObject("treeView1.AccessibleDescription")));
            this.treeView1.AccessibleName = ((string)(resources.GetObject("treeView1.AccessibleName")));
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("treeView1.Anchor")));
            this.treeView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("treeView1.BackgroundImage")));
            this.treeView1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("treeView1.Dock")));
            this.treeView1.Enabled = ((bool)(resources.GetObject("treeView1.Enabled")));
            this.treeView1.Font = ((System.Drawing.Font)(resources.GetObject("treeView1.Font")));
            this.treeView1.ImageIndex = ((int)(resources.GetObject("treeView1.ImageIndex")));
            this.treeView1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("treeView1.ImeMode")));
            this.treeView1.Indent = ((int)(resources.GetObject("treeView1.Indent")));
            this.treeView1.ItemHeight = ((int)(resources.GetObject("treeView1.ItemHeight")));
            this.treeView1.Location = ((System.Drawing.Point)(resources.GetObject("treeView1.Location")));
            this.treeView1.Name = "treeView1";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
                                                                                  ((System.Windows.Forms.TreeNode)(resources.GetObject("treeView1.Nodes.Nodes"))),
                                                                                  ((System.Windows.Forms.TreeNode)(resources.GetObject("treeView1.Nodes.Nodes1")))});
            this.treeView1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("treeView1.RightToLeft")));
            this.treeView1.SelectedImageIndex = ((int)(resources.GetObject("treeView1.SelectedImageIndex")));
            this.treeView1.Size = ((System.Drawing.Size)(resources.GetObject("treeView1.Size")));
            this.treeView1.TabIndex = ((int)(resources.GetObject("treeView1.TabIndex")));
            this.treeView1.Text = resources.GetString("treeView1.Text");
            this.toolTip.SetToolTip(this.treeView1, resources.GetString("treeView1.ToolTip"));
            this.treeView1.Visible = ((bool)(resources.GetObject("treeView1.Visible")));
            // 
            // buttonApplyLanguage
            // 
            this.buttonApplyLanguage.AccessibleDescription = ((string)(resources.GetObject("buttonApplyLanguage.AccessibleDescription")));
            this.buttonApplyLanguage.AccessibleName = ((string)(resources.GetObject("buttonApplyLanguage.AccessibleName")));
            this.buttonApplyLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("buttonApplyLanguage.Anchor")));
            this.buttonApplyLanguage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonApplyLanguage.BackgroundImage")));
            this.buttonApplyLanguage.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("buttonApplyLanguage.Dock")));
            this.buttonApplyLanguage.Enabled = ((bool)(resources.GetObject("buttonApplyLanguage.Enabled")));
            this.buttonApplyLanguage.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("buttonApplyLanguage.FlatStyle")));
            this.buttonApplyLanguage.Font = ((System.Drawing.Font)(resources.GetObject("buttonApplyLanguage.Font")));
            this.buttonApplyLanguage.Image = ((System.Drawing.Image)(resources.GetObject("buttonApplyLanguage.Image")));
            this.buttonApplyLanguage.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonApplyLanguage.ImageAlign")));
            this.buttonApplyLanguage.ImageIndex = ((int)(resources.GetObject("buttonApplyLanguage.ImageIndex")));
            this.buttonApplyLanguage.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("buttonApplyLanguage.ImeMode")));
            this.buttonApplyLanguage.Location = ((System.Drawing.Point)(resources.GetObject("buttonApplyLanguage.Location")));
            this.buttonApplyLanguage.Name = "buttonApplyLanguage";
            this.buttonApplyLanguage.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("buttonApplyLanguage.RightToLeft")));
            this.buttonApplyLanguage.Size = ((System.Drawing.Size)(resources.GetObject("buttonApplyLanguage.Size")));
            this.buttonApplyLanguage.TabIndex = ((int)(resources.GetObject("buttonApplyLanguage.TabIndex")));
            this.buttonApplyLanguage.Text = resources.GetString("buttonApplyLanguage.Text");
            this.buttonApplyLanguage.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonApplyLanguage.TextAlign")));
            this.toolTip.SetToolTip(this.buttonApplyLanguage, resources.GetString("buttonApplyLanguage.ToolTip"));
            this.buttonApplyLanguage.Visible = ((bool)(resources.GetObject("buttonApplyLanguage.Visible")));
            this.buttonApplyLanguage.Click += new System.EventHandler(this.button_Click);
            // 
            // panel
            // 
            this.panel.AccessibleDescription = ((string)(resources.GetObject("panel.AccessibleDescription")));
            this.panel.AccessibleName = ((string)(resources.GetObject("panel.AccessibleName")));
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel.Anchor")));
            this.panel.AutoScroll = ((bool)(resources.GetObject("panel.AutoScroll")));
            this.panel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel.AutoScrollMargin")));
            this.panel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel.AutoScrollMinSize")));
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                this.comboBoxLanguage,
                                                                                this.label,
                                                                                this.tabControl,
                                                                                this.buttonApplyLanguage});
            this.panel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel.Dock")));
            this.panel.Enabled = ((bool)(resources.GetObject("panel.Enabled")));
            this.panel.Font = ((System.Drawing.Font)(resources.GetObject("panel.Font")));
            this.panel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel.ImeMode")));
            this.panel.Location = ((System.Drawing.Point)(resources.GetObject("panel.Location")));
            this.panel.Name = "panel";
            this.panel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel.RightToLeft")));
            this.panel.Size = ((System.Drawing.Size)(resources.GetObject("panel.Size")));
            this.panel.TabIndex = ((int)(resources.GetObject("panel.TabIndex")));
            this.panel.Text = resources.GetString("panel.Text");
            this.toolTip.SetToolTip(this.panel, resources.GetString("panel.ToolTip"));
            this.panel.Visible = ((bool)(resources.GetObject("panel.Visible")));
            // 
            // toolBar
            // 
            this.toolBar.AccessibleDescription = ((string)(resources.GetObject("toolBar.AccessibleDescription")));
            this.toolBar.AccessibleName = ((string)(resources.GetObject("toolBar.AccessibleName")));
            this.toolBar.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("toolBar.Anchor")));
            this.toolBar.Appearance = ((System.Windows.Forms.ToolBarAppearance)(resources.GetObject("toolBar.Appearance")));
            this.toolBar.AutoSize = ((bool)(resources.GetObject("toolBar.AutoSize")));
            this.toolBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolBar.BackgroundImage")));
            this.toolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
                                                                                       this.toolBarButton1});
            this.toolBar.ButtonSize = ((System.Drawing.Size)(resources.GetObject("toolBar.ButtonSize")));
            this.toolBar.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("toolBar.Dock")));
            this.toolBar.DropDownArrows = ((bool)(resources.GetObject("toolBar.DropDownArrows")));
            this.toolBar.Enabled = ((bool)(resources.GetObject("toolBar.Enabled")));
            this.toolBar.Font = ((System.Drawing.Font)(resources.GetObject("toolBar.Font")));
            this.toolBar.ImageList = this.imageListToolbar;
            this.toolBar.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("toolBar.ImeMode")));
            this.toolBar.Location = ((System.Drawing.Point)(resources.GetObject("toolBar.Location")));
            this.toolBar.Name = "toolBar";
            this.toolBar.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("toolBar.RightToLeft")));
            this.toolBar.ShowToolTips = ((bool)(resources.GetObject("toolBar.ShowToolTips")));
            this.toolBar.Size = ((System.Drawing.Size)(resources.GetObject("toolBar.Size")));
            this.toolBar.TabIndex = ((int)(resources.GetObject("toolBar.TabIndex")));
            this.toolBar.TextAlign = ((System.Windows.Forms.ToolBarTextAlign)(resources.GetObject("toolBar.TextAlign")));
            this.toolTip.SetToolTip(this.toolBar, resources.GetString("toolBar.ToolTip"));
            this.toolBar.Visible = ((bool)(resources.GetObject("toolBar.Visible")));
            this.toolBar.Wrappable = ((bool)(resources.GetObject("toolBar.Wrappable")));
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Enabled = ((bool)(resources.GetObject("toolBarButton1.Enabled")));
            this.toolBarButton1.ImageIndex = ((int)(resources.GetObject("toolBarButton1.ImageIndex")));
            this.toolBarButton1.Text = resources.GetString("toolBarButton1.Text");
            this.toolBarButton1.ToolTipText = resources.GetString("toolBarButton1.ToolTipText");
            this.toolBarButton1.Visible = ((bool)(resources.GetObject("toolBarButton1.Visible")));
            // 
            // imageListToolbar
            // 
            this.imageListToolbar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListToolbar.ImageSize = ((System.Drawing.Size)(resources.GetObject("imageListToolbar.ImageSize")));
            this.imageListToolbar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListToolbar.ImageStream")));
            this.imageListToolbar.TransparentColor = System.Drawing.Color.Transparent;
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
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.panel,
                                                                          this.toolBar,
                                                                          this.statusBar});
            this.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("$this.Dock")));
            this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
            this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
            this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
            this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
            this.Menu = this.mainMenu;
            this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
            this.Name = "FormMain";
            this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
            this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
            this.Text = resources.GetString("$this.Text");
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Visible = ((bool)(resources.GetObject("$this.Visible")));
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            try {
                Application.Run(new FormMain());
            }
            catch (Exception e) {
                MessageBox.Show(e.Message + Environment.NewLine + e.StackTrace);
            }
		}

        private void button_Click(object sender, System.EventArgs e) {
            CultureInfoDisplayItem cidi = (CultureInfoDisplayItem)comboBoxLanguage.SelectedItem;
            FormLanguageSwitchSingleton.Instance.ChangeLanguage(this, cidi.CultureInfo);
        }

    }
}
