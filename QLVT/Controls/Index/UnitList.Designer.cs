﻿namespace PGS.Controls
{
    partial class UnitList
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            this.gridUnits = new Telerik.WinControls.UI.RadGridView();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnits.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUnits
            // 
            this.gridUnits.AutoSizeRows = true;
            this.gridUnits.BackColor = System.Drawing.SystemColors.Control;
            this.gridUnits.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUnits.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridUnits.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridUnits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridUnits.Location = new System.Drawing.Point(0, 0);
            // 
            // gridUnits
            // 
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "Unit_ID";
            gridViewDecimalColumn2.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewDecimalColumn2.HeaderText = "Unit_ID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "Unit_ID";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn8.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn8.FormatString = "";
            gridViewTextBoxColumn8.HeaderText = "No";
            gridViewTextBoxColumn8.Name = "No";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn8.Width = 24;
            gridViewTextBoxColumn9.FieldName = "UCode";
            gridViewTextBoxColumn9.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn9.FormatString = "";
            gridViewTextBoxColumn9.HeaderText = "Code";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "UCode";
            gridViewTextBoxColumn9.Width = 100;
            gridViewTextBoxColumn10.FieldName = "UName";
            gridViewTextBoxColumn10.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn10.FormatString = "";
            gridViewTextBoxColumn10.HeaderText = "Unit Name";
            gridViewTextBoxColumn10.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "UName";
            gridViewTextBoxColumn10.Width = 150;
            gridViewTextBoxColumn10.WrapText = true;
            gridViewTextBoxColumn11.FieldName = "UGroup";
            gridViewTextBoxColumn11.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn11.FormatString = "";
            gridViewTextBoxColumn11.HeaderText = "Group";
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.Name = "UGroup";
            gridViewTextBoxColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn11.Width = 120;
            gridViewCheckBoxColumn2.AllowFiltering = false;
            gridViewCheckBoxColumn2.AllowGroup = false;
            gridViewCheckBoxColumn2.AllowResize = false;
            gridViewCheckBoxColumn2.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn2.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text;
            gridViewCheckBoxColumn2.FieldName = "Active";
            gridViewCheckBoxColumn2.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewCheckBoxColumn2.FormatString = "";
            gridViewCheckBoxColumn2.HeaderText = "Active";
            gridViewCheckBoxColumn2.IsAutoGenerated = true;
            gridViewCheckBoxColumn2.MinWidth = 20;
            gridViewCheckBoxColumn2.Name = "Active";
            gridViewTextBoxColumn12.FieldName = "UNotes";
            gridViewTextBoxColumn12.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn12.FormatString = "";
            gridViewTextBoxColumn12.HeaderText = "Notes";
            gridViewTextBoxColumn12.IsAutoGenerated = true;
            gridViewTextBoxColumn12.Multiline = true;
            gridViewTextBoxColumn12.Name = "UNotes";
            gridViewTextBoxColumn12.Width = 250;
            gridViewTextBoxColumn12.WrapText = true;
            gridViewDateTimeColumn2.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn2.FieldName = "UpdatedDate";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewDateTimeColumn2.HeaderText = "UpdatedDate";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.IsVisible = false;
            gridViewDateTimeColumn2.Name = "UpdatedDate";
            gridViewTextBoxColumn13.DataType = typeof(System.Collections.Generic.ICollection<PGS.Entity.Equipment>);
            gridViewTextBoxColumn13.FieldName = "Equipments";
            gridViewTextBoxColumn13.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn13.HeaderText = "Equipments";
            gridViewTextBoxColumn13.IsAutoGenerated = true;
            gridViewTextBoxColumn13.IsVisible = false;
            gridViewTextBoxColumn13.Name = "Equipments";
            gridViewTextBoxColumn14.DataType = typeof(System.Collections.Generic.ICollection<PGS.Entity.Material>);
            gridViewTextBoxColumn14.FieldName = "Materials";
            gridViewTextBoxColumn14.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewTextBoxColumn14.HeaderText = "Materials";
            gridViewTextBoxColumn14.IsAutoGenerated = true;
            gridViewTextBoxColumn14.IsVisible = false;
            gridViewTextBoxColumn14.Name = "Materials";
            this.gridUnits.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn12,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14});
            this.gridUnits.MasterTemplate.DataSource = this.unitBindingSource;
            sortDescriptor2.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor2.PropertyName = "UCode";
            this.gridUnits.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.gridUnits.Name = "gridUnits";
            this.gridUnits.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.gridUnits.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.gridUnits.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.gridUnits.Size = new System.Drawing.Size(755, 513);
            this.gridUnits.TabIndex = 0;
            this.gridUnits.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.gridUnits_CellFormatting);
            this.gridUnits.CellValidating += new Telerik.WinControls.UI.CellValidatingEventHandler(this.gridUnits_CellValidating);
            this.gridUnits.UserAddingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.gridUnits_UserAddingRow);
            this.gridUnits.UserAddedRow += new Telerik.WinControls.UI.GridViewRowEventHandler(this.gridUnits_UserAddedRow);
            this.gridUnits.UserDeletingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.gridUnits_UserDeletingRow);
            this.gridUnits.UserDeletedRow += new Telerik.WinControls.UI.GridViewRowEventHandler(this.gridUnits_UserDeletedRow);
            this.gridUnits.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridUnits_CellValueChanged);
            this.gridUnits.DataBindingComplete += new Telerik.WinControls.UI.GridViewBindingCompleteEventHandler(this.gridUnits_DataBindingComplete);
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(PGS.Entity.Unit);
            // 
            // UnitList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridUnits);
            this.Name = "UnitList";
            this.Size = new System.Drawing.Size(755, 513);
            ((System.ComponentModel.ISupportInitialize)(this.gridUnits.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridUnits;
        private System.Windows.Forms.BindingSource unitBindingSource;
    }
}
