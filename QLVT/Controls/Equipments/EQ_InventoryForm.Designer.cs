namespace PGS.Controls
{
    partial class EQ_InventoryForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.topPanel = new Telerik.WinControls.UI.RadPanel();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.bottomPanel = new Telerik.WinControls.UI.RadPanel();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.btnImport = new Telerik.WinControls.UI.RadButton();
            this.btnExport = new Telerik.WinControls.UI.RadButton();
            this.btnToExcel = new Telerik.WinControls.UI.RadButton();
            this.centerPanel = new Telerik.WinControls.UI.RadPanel();
            this.gridPanel = new Telerik.WinControls.UI.RadPanel();
            this.gridResult = new Telerik.WinControls.UI.RadGridView();
            this.leftPanel = new Telerik.WinControls.UI.RadPanel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.cboStore = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanel)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerPanel)).BeginInit();
            this.centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPanel)).BeginInit();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPanel)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.btnSearch);
            this.topPanel.Controls.Add(this.txtSearch);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(790, 36);
            this.topPanel.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(660, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(312, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(340, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TabStop = false;
            this.txtSearch.Text = "type code, name or part-number to search";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.btnClose);
            this.bottomPanel.Controls.Add(this.btnImport);
            this.bottomPanel.Controls.Add(this.btnExport);
            this.bottomPanel.Controls.Add(this.btnSave);
            this.bottomPanel.Controls.Add(this.btnToExcel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 556);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(790, 44);
            this.bottomPanel.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(695, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 26);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE";
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnImport.Location = new System.Drawing.Point(10, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(120, 40);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "IMPORT FROM OTHER STORES";
            this.btnImport.TextWrap = true;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExport.Location = new System.Drawing.Point(464, 9);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(70, 26);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "EXPORT";
            this.btnExport.Visible = false;
            // 
            // btnToExcel
            // 
            this.btnToExcel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnToExcel.Location = new System.Drawing.Point(541, 9);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(70, 26);
            this.btnToExcel.TabIndex = 2;
            this.btnToExcel.Text = "TO EXCEL";
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.gridPanel);
            this.centerPanel.Controls.Add(this.leftPanel);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 36);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(790, 520);
            this.centerPanel.TabIndex = 2;
            this.centerPanel.Text = "centerPanel";
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.gridResult);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Location = new System.Drawing.Point(210, 0);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(580, 520);
            this.gridPanel.TabIndex = 1;
            this.gridPanel.Text = "gridPanel";
            // 
            // gridResult
            // 
            this.gridResult.BackColor = System.Drawing.SystemColors.Control;
            this.gridResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridResult.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridResult.ForeColor = System.Drawing.Color.Black;
            this.gridResult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridResult.Location = new System.Drawing.Point(0, 0);
            // 
            // gridResult
            // 
            this.gridResult.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn1.HeaderText = "No";
            gridViewTextBoxColumn1.Name = "No";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 36;
            gridViewTextBoxColumn2.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn2.HeaderText = "Item Code";
            gridViewTextBoxColumn2.Name = "Code";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn3.HeaderText = "Description";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.Multiline = true;
            gridViewTextBoxColumn3.Name = "Description";
            gridViewTextBoxColumn3.Width = 150;
            gridViewTextBoxColumn3.WrapText = true;
            gridViewTextBoxColumn4.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn4.HeaderText = "Part-Number";
            gridViewTextBoxColumn4.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn4.Name = "PartNumber";
            gridViewTextBoxColumn4.Width = 80;
            gridViewTextBoxColumn5.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn5.HeaderText = "Min-Level";
            gridViewTextBoxColumn5.Name = "MinLevel";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 80;
            gridViewTextBoxColumn6.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn6.HeaderText = "In-Stock";
            gridViewTextBoxColumn6.Name = "InStock";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 60;
            gridViewTextBoxColumn7.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn7.HeaderText = "In-Use";
            gridViewTextBoxColumn7.Name = "InUse";
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 60;
            gridViewTextBoxColumn8.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn8.HeaderText = "Location";
            gridViewTextBoxColumn8.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn8.Name = "Location";
            gridViewTextBoxColumn8.Width = 150;
            gridViewTextBoxColumn9.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn9.HeaderText = "In Order *";
            gridViewTextBoxColumn9.Name = "InOrder";
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn9.Width = 60;
            gridViewTextBoxColumn10.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn10.HeaderText = "Remarks";
            gridViewTextBoxColumn10.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn10.Name = "Remarks";
            gridViewTextBoxColumn10.Width = 120;
            this.gridResult.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10});
            this.gridResult.Name = "gridResult";
            this.gridResult.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.gridResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.gridResult.RootElement.ForeColor = System.Drawing.Color.Black;
            this.gridResult.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.gridResult.Size = new System.Drawing.Size(580, 520);
            this.gridResult.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.radPanel1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(210, 520);
            this.leftPanel.TabIndex = 0;
            this.leftPanel.Text = "Tree view of Equipment";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.cboStore);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(210, 47);
            this.radPanel1.TabIndex = 0;
            // 
            // cboStore
            // 
            this.cboStore.Location = new System.Drawing.Point(10, 20);
            this.cboStore.Name = "cboStore";
            this.cboStore.Size = new System.Drawing.Size(190, 20);
            this.cboStore.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(5, 4);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(35, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Store:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(618, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 26);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            // 
            // EQ_InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "EQ_InventoryForm";
            this.Size = new System.Drawing.Size(790, 600);
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanel)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerPanel)).EndInit();
            this.centerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPanel)).EndInit();
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResult.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPanel)).EndInit();
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel topPanel;
        private Telerik.WinControls.UI.RadPanel bottomPanel;
        private Telerik.WinControls.UI.RadPanel centerPanel;
        private Telerik.WinControls.UI.RadPanel gridPanel;
        private Telerik.WinControls.UI.RadPanel leftPanel;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadTextBox txtSearch;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList cboStore;
        private Telerik.WinControls.UI.RadGridView gridResult;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadButton btnToExcel;
        private Telerik.WinControls.UI.RadButton btnImport;
        private Telerik.WinControls.UI.RadButton btnExport;
        private Telerik.WinControls.UI.RadButton btnSave;
    }
}
