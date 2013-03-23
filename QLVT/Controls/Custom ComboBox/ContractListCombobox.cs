using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI.Localization;
using PGS.Entity;

namespace PGS.Controls.Custom_ComboBox
{
    class ContractListCombobox:RadMultiColumnComboBox
    {
        private PGS.Entity.PGSDBEntities dbContext = EQ_MainForm.dbContext;
        public void LoadItems()
        {
            FilterDescriptor descriptor = new FilterDescriptor("Code", FilterOperator.StartsWith, string.Empty);
            this.EditorControl.FilterDescriptors.Add(descriptor);
            this.DropDownStyle = RadDropDownStyle.DropDown;
            this.AutoFilter = true;

            this.AutoSizeDropDownToBestFit = true;
            RadMultiColumnComboBoxElement multiColumnComboElement = this.MultiColumnComboBoxElement;
            multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
            multiColumnComboElement.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            GridViewTextBoxColumn column = new GridViewTextBoxColumn("Code");
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Date");
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Notes");
            multiColumnComboElement.Columns.Add(column);
            this.DataSource = dbContext.EQ_Contracts.ToList<EQ_Contracts>();
            this.DisplayMember = "Code";
            this.ValueMember = "Contract_ID";           
        }
    }
}
