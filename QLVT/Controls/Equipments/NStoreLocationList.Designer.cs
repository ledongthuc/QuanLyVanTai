namespace PGS.Controls
{
    partial class NStoreLocationList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.topPanel = new Telerik.WinControls.UI.RadPanel();
            this.cboStore = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnView = new Telerik.WinControls.UI.RadButton();
            this.bottomPanel = new Telerik.WinControls.UI.RadPanel();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.btnToExcel = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.gridLocation = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanel)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLocation.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.cboStore);
            this.topPanel.Controls.Add(this.radLabel1);
            this.topPanel.Controls.Add(this.btnView);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(790, 44);
            this.topPanel.TabIndex = 0;
            // 
            // cboStore
            // 
            this.cboStore.Location = new System.Drawing.Point(117, 12);
            this.cboStore.Name = "cboStore";
            this.cboStore.Size = new System.Drawing.Size(196, 20);
            this.cboStore.TabIndex = 18;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(78, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(35, 18);
            this.radLabel1.TabIndex = 10;
            this.radLabel1.Text = "Store:";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnView.Location = new System.Drawing.Point(364, 9);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(70, 26);
            this.btnView.TabIndex = 24;
            this.btnView.Text = "VIEW";
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.btnClose);
            this.bottomPanel.Controls.Add(this.btnToExcel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 496);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(790, 44);
            this.bottomPanel.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(694, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 26);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "CLOSE";
            // 
            // btnToExcel
            // 
            this.btnToExcel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnToExcel.Location = new System.Drawing.Point(618, 9);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(70, 26);
            this.btnToExcel.TabIndex = 3;
            this.btnToExcel.Text = "TO EXCEL";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.gridLocation);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 44);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(790, 452);
            this.radPanel1.TabIndex = 2;
            // 
            // gridLocation
            // 
            this.gridLocation.BackColor = System.Drawing.SystemColors.Control;
            this.gridLocation.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLocation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridLocation.ForeColor = System.Drawing.Color.Black;
            this.gridLocation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridLocation.Location = new System.Drawing.Point(0, 0);
            // 
            // gridLocation
            // 
            gridViewTextBoxColumn1.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn1.HeaderText = "Location";
            gridViewTextBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn1.Name = "Location";
            gridViewTextBoxColumn1.Width = 250;
            gridViewTextBoxColumn2.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn2.HeaderText = "Description";
            gridViewTextBoxColumn2.Multiline = true;
            gridViewTextBoxColumn2.Name = "Description";
            gridViewTextBoxColumn2.Width = 450;
            gridViewTextBoxColumn2.WrapText = true;
            this.gridLocation.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.gridLocation.Name = "gridLocation";
            this.gridLocation.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.gridLocation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.gridLocation.RootElement.ForeColor = System.Drawing.Color.Black;
            this.gridLocation.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.gridLocation.Size = new System.Drawing.Size(790, 452);
            this.gridLocation.TabIndex = 0;
            this.gridLocation.Text = "radGridView1";
            // 
            // NStoreLocationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "NStoreLocationList";
            this.Size = new System.Drawing.Size(790, 540);
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanel)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLocation.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel topPanel;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel bottomPanel;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadButton btnToExcel;
        private Telerik.WinControls.UI.RadDropDownList cboStore;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGridView gridLocation;
        private Telerik.WinControls.UI.RadButton btnView;
    }
}
