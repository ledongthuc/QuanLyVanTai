namespace PGS.Controls
{
    partial class NEQ_RequestListControl
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.topPanel = new Telerik.WinControls.UI.RadPanel();
            this.btnXem = new Telerik.WinControls.UI.RadButton();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.cbNoiGui = new Telerik.WinControls.UI.RadDropDownList();
            this.dateDenNgay = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dateTuNgay = new Telerik.WinControls.UI.RadDateTimePicker();
            this.cbTinhTrang = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.gridVatTu = new Telerik.WinControls.UI.RadGridView();
            this.bottomPanel = new Telerik.WinControls.UI.RadPanel();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.btnImport = new Telerik.WinControls.UI.RadButton();
            this.btnToExcel = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNoiGui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTinhTrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVatTu.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanel)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.btnXem);
            this.topPanel.Controls.Add(this.radLabel7);
            this.topPanel.Controls.Add(this.cbNoiGui);
            this.topPanel.Controls.Add(this.dateDenNgay);
            this.topPanel.Controls.Add(this.radLabel1);
            this.topPanel.Controls.Add(this.dateTuNgay);
            this.topPanel.Controls.Add(this.cbTinhTrang);
            this.topPanel.Controls.Add(this.radLabel5);
            this.topPanel.Controls.Add(this.radLabel4);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 79);
            this.topPanel.TabIndex = 5;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXem.Location = new System.Drawing.Point(589, 15);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(80, 40);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "VIEW";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(13, 49);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(91, 18);
            this.radLabel7.TabIndex = 8;
            this.radLabel7.Text = "Requested Store:";
            // 
            // cbNoiGui
            // 
            this.cbNoiGui.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbNoiGui.Location = new System.Drawing.Point(108, 48);
            this.cbNoiGui.Name = "cbNoiGui";
            this.cbNoiGui.Size = new System.Drawing.Size(180, 20);
            this.cbNoiGui.TabIndex = 2;
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateDenNgay.Location = new System.Drawing.Point(346, 7);
            this.dateDenNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateDenNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.NullDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateDenNgay.Size = new System.Drawing.Size(160, 20);
            this.dateDenNgay.TabIndex = 1;
            this.dateDenNgay.TabStop = false;
            this.dateDenNgay.Text = "radDateTimePicker1";
            this.dateDenNgay.Value = new System.DateTime(2012, 7, 19, 14, 48, 18, 688);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(321, 9);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(21, 18);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "To:";
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTuNgay.Location = new System.Drawing.Point(108, 8);
            this.dateTuNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTuNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.NullDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTuNgay.Size = new System.Drawing.Size(160, 20);
            this.dateTuNgay.TabIndex = 0;
            this.dateTuNgay.TabStop = false;
            this.dateTuNgay.Text = "radDateTimePicker1";
            this.dateTuNgay.Value = new System.DateTime(2012, 7, 19, 14, 48, 18, 688);
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbTinhTrang.Location = new System.Drawing.Point(390, 48);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(160, 20);
            this.cbTinhTrang.TabIndex = 3;
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(346, 49);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(39, 18);
            this.radLabel5.TabIndex = 3;
            this.radLabel5.Text = "Status:";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(70, 9);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(34, 18);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "From:";
            // 
            // gridVatTu
            // 
            this.gridVatTu.BackColor = System.Drawing.SystemColors.Control;
            this.gridVatTu.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridVatTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVatTu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridVatTu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridVatTu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridVatTu.Location = new System.Drawing.Point(0, 0);
            // 
            // gridVatTu
            // 
            this.gridVatTu.MasterTemplate.AllowAddNewRow = false;
            this.gridVatTu.MasterTemplate.AllowDeleteRow = false;
            this.gridVatTu.MasterTemplate.AllowEditRow = false;
            this.gridVatTu.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn1.HeaderText = "Request Code";
            gridViewTextBoxColumn1.Name = "column2";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 120;
            gridViewTextBoxColumn2.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn2.FormatString = "{0:dd/MM/yyyy}";
            gridViewTextBoxColumn2.HeaderText = "Requested Date";
            gridViewTextBoxColumn2.Name = "column1";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 120;
            gridViewTextBoxColumn3.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn3.HeaderText = "Requester";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.Name = "column4";
            gridViewTextBoxColumn3.Width = 160;
            gridViewTextBoxColumn4.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn4.HeaderText = "Status";
            gridViewTextBoxColumn4.Name = "column7";
            gridViewTextBoxColumn4.Width = 120;
            gridViewTextBoxColumn5.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn5.HeaderText = "Prioirty";
            gridViewTextBoxColumn5.Name = "column3";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 100;
            gridViewTextBoxColumn6.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn6.HeaderText = "Notes";
            gridViewTextBoxColumn6.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn6.Multiline = true;
            gridViewTextBoxColumn6.Name = "column5";
            gridViewTextBoxColumn6.Width = 250;
            gridViewTextBoxColumn6.WrapText = true;
            this.gridVatTu.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.gridVatTu.MasterTemplate.EnableFiltering = true;
            this.gridVatTu.MasterTemplate.EnableGrouping = false;
            this.gridVatTu.Name = "gridVatTu";
            this.gridVatTu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.gridVatTu.ReadOnly = true;
            this.gridVatTu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.gridVatTu.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.gridVatTu.Size = new System.Drawing.Size(800, 397);
            this.gridVatTu.TabIndex = 5;
            this.gridVatTu.Text = "radGridView1";
            this.gridVatTu.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridVatTu_CellDoubleClick);
            this.gridVatTu.DoubleClick += new System.EventHandler(this.gridVatTu_DoubleClick);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.btnClose);
            this.bottomPanel.Controls.Add(this.btnImport);
            this.bottomPanel.Controls.Add(this.btnToExcel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 476);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(800, 44);
            this.bottomPanel.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(724, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 26);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "CLOSE";
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnImport.Location = new System.Drawing.Point(548, 9);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(60, 26);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "IMPORT";
            // 
            // btnToExcel
            // 
            this.btnToExcel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnToExcel.Location = new System.Drawing.Point(636, 9);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(60, 26);
            this.btnToExcel.TabIndex = 5;
            this.btnToExcel.Text = "TO EXCEL";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.gridVatTu);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 79);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(800, 397);
            this.radPanel1.TabIndex = 7;
            // 
            // NEQ_RequestListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "NEQ_RequestListControl";
            this.Size = new System.Drawing.Size(800, 520);
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNoiGui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTinhTrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVatTu.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanel)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel topPanel;
        private Telerik.WinControls.UI.RadDateTimePicker dateDenNgay;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDateTimePicker dateTuNgay;
        private Telerik.WinControls.UI.RadDropDownList cbTinhTrang;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadDropDownList cbNoiGui;
        private Telerik.WinControls.UI.RadButton btnXem;
        private Telerik.WinControls.UI.RadGridView gridVatTu;
        private Telerik.WinControls.UI.RadPanel bottomPanel;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadButton btnImport;
        private Telerik.WinControls.UI.RadButton btnToExcel;
    }
}
