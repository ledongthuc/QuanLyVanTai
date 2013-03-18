using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using PGS.Entity;
using PGS.Utils;

namespace PGS.Controls
{
    public class RequestListCombobox : RadMultiColumnComboBox
    {
        private PGS.Entity.PGSDBEntities dbContext = EQ_MainForm.dbContext;
        public RequestListCombobox()
        {
        }
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
            column.FormatString = "{0:dd/MM/yyyy}";
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Notes");
            multiColumnComboElement.Columns.Add(column);
            this.DataSource = dbContext.EQ_Requests.ToList<EQ_Requests>();
            this.DisplayMember = "Code";
            this.ValueMember = "Code";
        }

        public void Load_MatItems()
        {
            FilterDescriptor descriptor = new FilterDescriptor("Code", FilterOperator.StartsWith, string.Empty);
            this.EditorControl.FilterDescriptors.Add(descriptor);
            this.DropDownStyle = RadDropDownStyle.DropDown;
            this.AutoFilter = true;

            this.AutoSizeDropDownToBestFit = true;
            RadMultiColumnComboBoxElement multiColumnComboElement = this.MultiColumnComboBoxElement;
            multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
            multiColumnComboElement.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            GridViewTextBoxColumn column = new GridViewTextBoxColumn("RequestID");
            column.IsVisible = false;
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Code");
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Date");
            column.FormatString = "{0:dd/MM/yyyy}";
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Notes");
            multiColumnComboElement.Columns.Add(column);
            this.DataSource = dbContext.Mat_Requests.ToList<Mat_Requests>();
            this.DisplayMember = "Code";
            this.ValueMember = "RequestID";
        }

        public void Load_MatRequestForOrder()
        {
            FilterDescriptor descriptor = new FilterDescriptor("Code", FilterOperator.StartsWith, string.Empty);
            this.EditorControl.FilterDescriptors.Add(descriptor);
            this.DropDownStyle = RadDropDownStyle.DropDown;
            this.AutoFilter = true;

            this.AutoSizeDropDownToBestFit = true;
            RadMultiColumnComboBoxElement multiColumnComboElement = this.MultiColumnComboBoxElement;
            multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
            multiColumnComboElement.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            GridViewTextBoxColumn column = new GridViewTextBoxColumn("RequestID");
            column.IsVisible = false;
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Code");
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Date");
            column.FormatString = "{0:dd/MM/yyyy}";
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Notes");
            multiColumnComboElement.Columns.Add(column);
            this.DataSource = dbContext.Mat_Requests.Where(mr => mr.Status != "Chưa được duyệt" && mr.Status != "Kết thúc").ToList<Mat_Requests>();
            this.DisplayMember = "Code";
            this.ValueMember = "RequestID";
        }

    }
}
