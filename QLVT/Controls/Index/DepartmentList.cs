using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using PGS.Entity;
using PGS.Utils;

namespace PGS.Controls
{
    public partial class DepartmentList : UserControl
    {
        bool dataBindingCompleted = false;

        public DepartmentList()
        {
            InitializeComponent();
            InitData();
        }

        public void InitData()
        {
            dataBindingCompleted = false;
            this.gridDepartments.DataSource = EQ_MainForm.dbContext.Departments.ToList<Department>();
        }

        private void gridDepartments_DataBindingComplete(object sender, Telerik.WinControls.UI.GridViewBindingCompleteEventArgs e)
        {
            dataBindingCompleted = true;
        }

        private void gridDepartments_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement.ColumnInfo.Name == "No" && string.IsNullOrEmpty(e.CellElement.Text))
            {
                e.CellElement.Text = (e.CellElement.RowIndex + 1).ToString();
            }
        }

        private bool CheckValidation()
        {
            ArrayList arrError = new ArrayList();
            string errorMsg = "";

            if (Helper.ConvertToString(gridDepartments.CurrentRow.Cells["DeptCode"].Value) == string.Empty)
                arrError.Add("- Input the code for Department.");
            if (Helper.ConvertToString(gridDepartments.CurrentRow.Cells["DeptName"].Value) == string.Empty)
                arrError.Add("- Input the name of Department.");

            if (arrError.Count > 0)
            {
                foreach (string s in arrError)
                    errorMsg += s + "\r\n";
                Helper.ShowError(errorMsg);
                return false;
            }
            return true;
        }
        private void gridDepartments_UserAddingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            if (CheckValidation() == false)
                e.Cancel = true;
        }
        private void gridDepartments_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            Department newDepartment = new Department();
            newDepartment.DeptCode = Helper.ConvertToString(e.Row.Cells["DeptCode"].Value);
            newDepartment.DeptName = Helper.ConvertToString(e.Row.Cells["DeptName"].Value);
            //newDepartment.ParentID = -1;
            newDepartment.DeptNotes = Helper.ConvertToString(e.Row.Cells["DeptNotes"].Value);
            if (Helper.ConvertToString(e.Row.Cells["Active"].Value) != string.Empty)
                newDepartment.Active = (bool)e.Row.Cells["Active"].Value;
            else newDepartment.Active = false;
            newDepartment.UpdatedDate = DateTime.Now;

            EQ_MainForm.dbContext.Departments.Add(newDepartment);
            EQ_MainForm.dbContext.SaveChanges();
            InitData(); // rebound datasource
            Helper.ShowInformation("A new DEPARTMENT has been created under line " + (e.Row.Index + 1).ToString());
        }

        private void gridDepartments_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            if (Helper.ShowQuestion("Are you sure to delete this item?") != DialogResult.Yes)
                e.Cancel = true;
        }
        private void gridDepartments_UserDeletedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            //Helper.ShowInformation("gridDepartments_UserDeletedRow");
            Department currentDept = new Department();
            currentDept = (Department)e.Row.DataBoundItem;
            if (currentDept != null)
            {
                EQ_MainForm.dbContext.Departments.Remove(currentDept);
                EQ_MainForm.dbContext.SaveChanges();
            }
        }

        private void gridDepartments_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (dataBindingCompleted && e.RowIndex >= 0)
            {
                //Helper.ShowInformation("gridDepartments_CellValueChanged at: " + (e.RowIndex + 1).ToString());
                Department currentDept = new Department();
                currentDept = (Department)e.Row.DataBoundItem;
                if (currentDept != null)
                {
                    switch (gridDepartments.CurrentColumn.Name)
                    {
                        case "DeptCode":
                            currentDept.DeptCode = Helper.ConvertToString(e.Row.Cells["DeptCode"].Value);
                            break;
                        case "DeptName":
                            currentDept.DeptName = Helper.ConvertToString(e.Row.Cells["DeptName"].Value);
                            break;
                        case "ParentID":
                            //currentDept.ParentID = -1;
                            break;
                        case "DeptNotes":
                            currentDept.DeptNotes = Helper.ConvertToString(e.Row.Cells["DeptNotes"].Value);
                            break;
                        case "Active":
                            currentDept.Active = (bool)e.Row.Cells["Active"].Value;
                            break;
                        default: 
                            break;
                    }
                    currentDept.UpdatedDate = DateTime.Now;
                    EQ_MainForm.dbContext.SaveChanges();
                }
            }
        }

        private void gridDepartments_CellValidating(object sender, Telerik.WinControls.UI.CellValidatingEventArgs e)
        {
            if (e.RowIndex < 0)  // Don't check if it's the new adding row
                return;
            switch (gridDepartments.CurrentColumn.Name)
            {
                case "DeptCode":
                    string sCode = Helper.ConvertToString(e.Value);
                    // Code cannot be empty
                    if (sCode == string.Empty)
                    {
                        Helper.ShowError("Input the code for Department.");
                        e.Cancel = true;
                    }
                    else
                    {
                        string oldCode = Helper.ConvertToString(e.OldValue);
                        // If a new code is input
                        if (sCode != oldCode)
                        {
                            Department currentDept = EQ_MainForm.dbContext.Departments.FirstOrDefault(d => d.DeptCode == sCode);
                            if (currentDept != null) // Code is already existed
                            {
                                Helper.ShowError("The code is already existed. Input another code.");
                                e.Cancel = true;
                            }
                        }
                    }
                    break;
                case "DeptName":
                    // Name cannot be empty
                    if (Helper.ConvertToString(e.Value) == string.Empty)
                    {
                        Helper.ShowError("Input the name of Department.");
                        e.Cancel = true;
                    }
                    break;
                default:
                    break;
            }
        }

     }
}
