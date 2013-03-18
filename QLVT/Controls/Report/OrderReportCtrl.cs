using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;
using PGS.Entity;

namespace PGS.Controls
{
    public partial class OrderReportCtrl : UserControl
    {
        private PGS.Entity.PGSDBEntities dbContext = EQ_MainForm.dbContext;

        public OrderReportCtrl()
        {
            InitializeComponent();
            InitData();
        }
    
        public void InitData()
        {
            RadGridLocalizationProvider.CurrentProvider = new RadGridENProvider();
            this.cbDepartment.LoadItems();
            this.cbSupplier.LoadItems();
        }

        private void rdDepartment_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            cbDepartment.Visible = rdDepartment.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
            cbSupplier.Visible = !(rdDepartment.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            IQueryable<Mat_Orders> searchResult = dbContext.Mat_Orders.Where(o => false);
            Department chosenDept = cbDepartment.SelectedItem.DataBoundItem as Department;
            Supplier chosenSupplier = cbSupplier.SelectedSupplier as Supplier;

            gridOrder.Rows.Clear();
            if (rdDepartment.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                searchResult = dbContext.Mat_Orders.Where(o => o.Mat_Requests.DeptIDSend == chosenDept.DeptID);
            }
            else
            {
                if (chosenSupplier != null)
                    searchResult = dbContext.Mat_Orders.Where(o => o.SupplierID == chosenSupplier.SupplierID);
            }

            gridOrder.DataSource = searchResult.ToList();

        }

        private void gridOrder_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            switch (e.CellElement.ColumnInfo.Name)
            {
                case "Mat_Requests":
                    if (e.CellElement.Value != null)
                        e.CellElement.Text = (e.CellElement.Value as Mat_Requests).Code;
                    break;
                case "Supplier":
                    if (e.CellElement.Value != null)
                        e.CellElement.Text = (e.CellElement.Value as Supplier).Name;
                    break;

            }
        }
   
    }
}
