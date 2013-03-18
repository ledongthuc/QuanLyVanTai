namespace PGS.Controls
{
    partial class OrderReportCtrl
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn4 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.cbSupplier = new PGS.Controls.SupplierListCombobox();
            this.cbDepartment = new PGS.Controls.DepartmentListCombobox();
            this.btnReport = new Telerik.WinControls.UI.RadButton();
            this.rdSupplier = new Telerik.WinControls.UI.RadRadioButton();
            this.rdDepartment = new Telerik.WinControls.UI.RadRadioButton();
            this.gridOrder = new Telerik.WinControls.UI.RadGridView();
            this.matOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.cbSupplier);
            this.radPanel1.Controls.Add(this.cbDepartment);
            this.radPanel1.Controls.Add(this.btnReport);
            this.radPanel1.Controls.Add(this.rdSupplier);
            this.radPanel1.Controls.Add(this.rdDepartment);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(800, 74);
            this.radPanel1.TabIndex = 0;
            // 
            // cbSupplier
            // 
            // 
            // cbSupplier.NestedRadGridView
            // 
            this.cbSupplier.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.cbSupplier.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplier.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbSupplier.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.cbSupplier.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.cbSupplier.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.cbSupplier.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.cbSupplier.EditorControl.MasterTemplate.EnableGrouping = false;
            this.cbSupplier.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.cbSupplier.EditorControl.Name = "NestedRadGridView";
            this.cbSupplier.EditorControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.cbSupplier.EditorControl.ReadOnly = true;
            // 
            // 
            // 
            this.cbSupplier.EditorControl.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.cbSupplier.EditorControl.ShowGroupPanel = false;
            this.cbSupplier.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.cbSupplier.EditorControl.TabIndex = 0;
            this.cbSupplier.Location = new System.Drawing.Point(221, 27);
            this.cbSupplier.Name = "cbSupplier";
            // 
            // 
            // 
            this.cbSupplier.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.cbSupplier.Size = new System.Drawing.Size(240, 20);
            this.cbSupplier.TabIndex = 3;
            this.cbSupplier.TabStop = false;
            this.cbSupplier.Visible = false;
            // 
            // cbDepartment
            // 
            this.cbDepartment.Location = new System.Drawing.Point(215, 27);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(240, 20);
            this.cbDepartment.TabIndex = 2;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReport.Location = new System.Drawing.Point(560, 17);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(80, 40);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "REPORT";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // rdSupplier
            // 
            this.rdSupplier.Location = new System.Drawing.Point(29, 43);
            this.rdSupplier.Name = "rdSupplier";
            this.rdSupplier.Size = new System.Drawing.Size(140, 18);
            this.rdSupplier.TabIndex = 1;
            this.rdSupplier.Text = "     by Supplier";
            // 
            // rdDepartment
            // 
            this.rdDepartment.Location = new System.Drawing.Point(29, 13);
            this.rdDepartment.Name = "rdDepartment";
            this.rdDepartment.Size = new System.Drawing.Size(140, 18);
            this.rdDepartment.TabIndex = 0;
            this.rdDepartment.Text = "      by Department";
            this.rdDepartment.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.rdDepartment.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rdDepartment_ToggleStateChanged);
            // 
            // gridOrder
            // 
            this.gridOrder.BackColor = System.Drawing.SystemColors.Control;
            this.gridOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrder.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridOrder.Location = new System.Drawing.Point(0, 74);
            // 
            // gridOrder
            // 
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "OrderID";
            gridViewDecimalColumn1.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewDecimalColumn1.HeaderText = "OrderID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "OrderID";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn1.FieldName = "Code";
            gridViewTextBoxColumn1.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn1.HeaderText = "Code";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Code";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 80;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.FieldName = "Date";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewDateTimeColumn1.FormatString = "{0:dd/MM/yyyy}";
            gridViewDateTimeColumn1.HeaderText = "Date";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "Date";
            gridViewDateTimeColumn1.Width = 100;
            gridViewTextBoxColumn2.FieldName = "ContactPerson";
            gridViewTextBoxColumn2.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn2.HeaderText = "Contact Person";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "ContactPerson";
            gridViewTextBoxColumn2.Width = 150;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn2.FieldName = "SupplierID";
            gridViewDecimalColumn2.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewDecimalColumn2.HeaderText = "SupplierID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "SupplierID";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn3.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn3.FieldName = "RequestID";
            gridViewDecimalColumn3.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewDecimalColumn3.HeaderText = "RequestID";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "RequestID";
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn3.FieldName = "OrderReason";
            gridViewTextBoxColumn3.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn3.HeaderText = "OrderReason";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Multiline = true;
            gridViewTextBoxColumn3.Name = "OrderReason";
            gridViewTextBoxColumn3.Width = 200;
            gridViewTextBoxColumn3.WrapText = true;
            gridViewTextBoxColumn4.FieldName = "Status";
            gridViewTextBoxColumn4.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn4.HeaderText = "Status";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Status";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 90;
            gridViewTextBoxColumn5.FieldName = "Priority";
            gridViewTextBoxColumn5.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn5.HeaderText = "Priority";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "Priority";
            gridViewDateTimeColumn2.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn2.FieldName = "DeliveryDate";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewDateTimeColumn2.FormatString = "{0:dd/MM/yyyy}";
            gridViewDateTimeColumn2.HeaderText = "Delivery Date";
            gridViewDateTimeColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "DeliveryDate";
            gridViewDateTimeColumn2.Width = 100;
            gridViewTextBoxColumn6.FieldName = "DeliveryLocation";
            gridViewTextBoxColumn6.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn6.HeaderText = "DeliveryLocation";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "DeliveryLocation";
            gridViewTextBoxColumn7.FieldName = "Receiver";
            gridViewTextBoxColumn7.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn7.HeaderText = "Receiver";
            gridViewTextBoxColumn7.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "Receiver";
            gridViewTextBoxColumn7.Width = 150;
            gridViewTextBoxColumn8.FieldName = "OtherInfo";
            gridViewTextBoxColumn8.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn8.HeaderText = "OtherInfo";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "OtherInfo";
            gridViewTextBoxColumn9.FieldName = "Notes";
            gridViewTextBoxColumn9.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn9.HeaderText = "Notes";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "Notes";
            gridViewDecimalColumn4.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn4.FieldName = "Creator";
            gridViewDecimalColumn4.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewDecimalColumn4.HeaderText = "Creator";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.IsVisible = false;
            gridViewDecimalColumn4.Name = "Creator";
            gridViewDecimalColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDateTimeColumn3.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn3.FieldName = "CreatedDate";
            gridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn3.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewDateTimeColumn3.HeaderText = "CreatedDate";
            gridViewDateTimeColumn3.IsAutoGenerated = true;
            gridViewDateTimeColumn3.IsVisible = false;
            gridViewDateTimeColumn3.Name = "CreatedDate";
            gridViewDecimalColumn5.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn5.FieldName = "Updator";
            gridViewDecimalColumn5.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewDecimalColumn5.HeaderText = "Updator";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.IsVisible = false;
            gridViewDecimalColumn5.Name = "Updator";
            gridViewDecimalColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDateTimeColumn4.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn4.FieldName = "UpdatedDate";
            gridViewDateTimeColumn4.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn4.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewDateTimeColumn4.HeaderText = "UpdatedDate";
            gridViewDateTimeColumn4.IsAutoGenerated = true;
            gridViewDateTimeColumn4.IsVisible = false;
            gridViewDateTimeColumn4.Name = "UpdatedDate";
            gridViewTextBoxColumn10.DataType = typeof(System.Collections.Generic.ICollection<PGS.Entity.Mat_Inputs>);
            gridViewTextBoxColumn10.FieldName = "Mat_Inputs";
            gridViewTextBoxColumn10.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn10.HeaderText = "Mat_Inputs";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "Mat_Inputs";
            gridViewTextBoxColumn11.DataType = typeof(System.Collections.Generic.ICollection<PGS.Entity.Mat_Order_Details>);
            gridViewTextBoxColumn11.FieldName = "Mat_Order_Details";
            gridViewTextBoxColumn11.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn11.HeaderText = "Mat_Order_Details";
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.Name = "Mat_Order_Details";
            gridViewTextBoxColumn12.DataType = typeof(PGS.Entity.Mat_Requests);
            gridViewTextBoxColumn12.FieldName = "Mat_Requests";
            gridViewTextBoxColumn12.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn12.HeaderText = "Request Code";
            gridViewTextBoxColumn12.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn12.IsAutoGenerated = true;
            gridViewTextBoxColumn12.Name = "Mat_Requests";
            gridViewTextBoxColumn12.Width = 120;
            gridViewTextBoxColumn13.DataType = typeof(PGS.Entity.Supplier);
            gridViewTextBoxColumn13.FieldName = "Supplier";
            gridViewTextBoxColumn13.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn13.HeaderText = "Supplier";
            gridViewTextBoxColumn13.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn13.IsAutoGenerated = true;
            gridViewTextBoxColumn13.Name = "Supplier";
            gridViewTextBoxColumn13.Width = 150;
            this.gridOrder.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewDecimalColumn4,
            gridViewDateTimeColumn3,
            gridViewDecimalColumn5,
            gridViewDateTimeColumn4,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13});
            this.gridOrder.MasterTemplate.DataSource = this.matOrdersBindingSource;
            this.gridOrder.Name = "gridOrder";
            this.gridOrder.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.gridOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.gridOrder.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.gridOrder.Size = new System.Drawing.Size(800, 526);
            this.gridOrder.TabIndex = 1;
            this.gridOrder.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.gridOrder_CellFormatting);
            // 
            // matOrdersBindingSource
            // 
            this.matOrdersBindingSource.DataSource = typeof(PGS.Entity.Mat_Orders);
            // 
            // OrderReportCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridOrder);
            this.Controls.Add(this.radPanel1);
            this.Name = "OrderReportCtrl";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadRadioButton rdSupplier;
        private Telerik.WinControls.UI.RadRadioButton rdDepartment;
        private SupplierListCombobox cbSupplier;
        private DepartmentListCombobox cbDepartment;
        private Telerik.WinControls.UI.RadButton btnReport;
        private Telerik.WinControls.UI.RadGridView gridOrder;
        private System.Windows.Forms.BindingSource matOrdersBindingSource;
    }
}
