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
namespace PGS.Controls
{
    public class SupplierComparer : IEqualityComparer<Supplier>
    {
        #region IEqualityComparer<Supplier> Members

        public bool Equals(Supplier x, Supplier y)
        {
            return x.SupplierID.Equals(y.SupplierID);
        }

        public int GetHashCode(Supplier obj)
        {
            return obj.SupplierID.GetHashCode();
        }

        #endregion
    }

    class SupplierListCombobox : RadMultiColumnComboBox
    {
        private PGS.Entity.PGSDBEntities dbContext = EQ_MainForm.dbContext;
        public SupplierListCombobox()
        {
        }
        public void LoadItemsOfRequest(EQ_Requests request)
        {
            this.Text = string.Empty;
            RadMultiColumnComboBoxElement multiColumnComboElement = this.MultiColumnComboBoxElement;
            multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
            multiColumnComboElement.Columns.Clear();
            this.EditorControl.FilterDescriptors.Clear();
            multiColumnComboElement.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            GridViewTextBoxColumn column = new GridViewTextBoxColumn("Code");
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Name");
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Address");
            multiColumnComboElement.Columns.Add(column);
            
            FilterDescriptor descriptor = new FilterDescriptor("Name", FilterOperator.StartsWith, string.Empty);
            this.EditorControl.FilterDescriptors.Add(descriptor);
            this.DropDownStyle = RadDropDownStyle.DropDown;
            this.AutoFilter = true;
            this.AutoSizeDropDownToBestFit = true;

            this.DataSource = dbContext.EQ_QuoteSupplier.Where(qs => qs.EQ_Quotes.RequestID == request.RequestID).Select(qs => qs.Supplier).ToList<Supplier>().Distinct(new SupplierComparer());
            this.DisplayMember = "Name";
            this.ValueMember = "Code";
        }
        public void LoadItems()
        {
            FilterDescriptor descriptor = new FilterDescriptor("Name", FilterOperator.StartsWith, string.Empty);
            this.EditorControl.FilterDescriptors.Add(descriptor);
            this.DropDownStyle = RadDropDownStyle.DropDown;
            this.AutoFilter = true;

            this.AutoSizeDropDownToBestFit = true;
            RadMultiColumnComboBoxElement multiColumnComboElement = this.MultiColumnComboBoxElement;
            multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
            multiColumnComboElement.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            GridViewTextBoxColumn column = new GridViewTextBoxColumn("Code");
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Name");
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Address");
            multiColumnComboElement.Columns.Add(column);

            this.DataSource = dbContext.Suppliers.ToList<Supplier>();
            this.DisplayMember = "Name";
            this.ValueMember = "Code";
        }

        public Supplier SelectedSupplier
        {
            get
            {
                if (this.SelectedIndex >= 0)
                {
                    return (Supplier)((GridViewDataRowInfo)this.SelectedItem).DataBoundItem;
                }
                return null;
            }
        }

        internal void LoadItemsOfRequests(List<EQ_Requests> CurrentRequests)
        {
            this.Text = string.Empty;
            RadMultiColumnComboBoxElement multiColumnComboElement = this.MultiColumnComboBoxElement;
            multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
            multiColumnComboElement.Columns.Clear();
            this.EditorControl.FilterDescriptors.Clear();
            multiColumnComboElement.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            GridViewTextBoxColumn column = new GridViewTextBoxColumn("Code");
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Name");
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Address");
            multiColumnComboElement.Columns.Add(column);

            FilterDescriptor descriptor = new FilterDescriptor("Name", FilterOperator.StartsWith, string.Empty);
            this.EditorControl.FilterDescriptors.Add(descriptor);
            this.DropDownStyle = RadDropDownStyle.DropDown;
            this.AutoFilter = true;
            this.AutoSizeDropDownToBestFit = true;
            List<Supplier> source = new List<Supplier>();
            foreach (EQ_Requests request in CurrentRequests)
            {
                source.AddRange(dbContext.EQ_QuoteSupplier.Where(qs => qs.EQ_Quotes.RequestID == request.RequestID).Select(qs => qs.Supplier).ToList<Supplier>());
            }
            this.DataSource = source.Distinct(new SupplierComparer());
            this.DisplayMember = "Name";
            this.ValueMember = "Code";
        }
    }
}
