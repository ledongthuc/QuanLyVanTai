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
using Telerik.WinControls.UI;


namespace PGS.Controls
{
    public partial class EmployeeList : UserControl
    {
        bool dataBindingCompleted = false;

        public EmployeeList()
        {
            InitializeComponent();
            InitData();
            AddCommboboxex();
        }

        public void InitData()
        {
            dataBindingCompleted = false;
            this.gridEmployees.DataSource = EQ_MainForm.dbContext.Employees.ToList<Employee>();
        }
        private void AddCommboboxex()
        {
            GridViewComboBoxColumn column = this.gridEmployees.Columns["DeptID"] as GridViewComboBoxColumn;
            column.DataSource = EQ_MainForm.dbContext.Departments.Where(d => d.Active == true).ToList<Department>();
            column.DisplayMember = "DeptName";
            column.ValueMember = "DeptID";
        }

        private void gridEmployees_DataBindingComplete(object sender, Telerik.WinControls.UI.GridViewBindingCompleteEventArgs e)
        {
            dataBindingCompleted = true;
        }

        private void gridEmployees_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement.ColumnInfo.Name == "No" && string.IsNullOrEmpty(e.CellElement.Text))
            {
                e.CellElement.Text = (e.CellElement.RowIndex + 1).ToString();
            }
            if (e.CellElement.ColumnInfo.Name == "BirthDate" && Helper.ConvertToDate(e.CellElement.Text).Year == 1900)
            {
                e.CellElement.Text = "";
            }
            if (e.CellElement.ColumnInfo.Name == "IDIssuedDate" && Helper.ConvertToDate(e.CellElement.Text).Year == 1900)
            {
                e.CellElement.Text = "";
            }
            if (e.CellElement.ColumnInfo.Name == "PassportIssuedDate" && Helper.ConvertToDate(e.CellElement.Text).Year == 1900)
            {
                e.CellElement.Text = "";
            }
            if (e.CellElement.ColumnInfo.Name == "PassportExpiredDate" && Helper.ConvertToDate(e.CellElement.Text).Year == 1900)
            {
                e.CellElement.Text = "";
            }
        }

        private bool CheckValidation()
        {
            ArrayList arrError = new ArrayList();
            string errorMsg = "";

            if (Helper.ConvertToString(gridEmployees.CurrentRow.Cells["FirstName"].Value) == string.Empty)
                arrError.Add("- Input the Firstname of Employee.");
            if (Helper.ConvertToString(gridEmployees.CurrentRow.Cells["LastName"].Value) == string.Empty)
                arrError.Add("- Input the Lastname of Employee.");

            if (arrError.Count > 0)
            {
                foreach (string s in arrError)
                    errorMsg += s + "\r\n";
                Helper.ShowError(errorMsg);
                return false;
            }
            return true;
        }
        private void gridEmployees_UserAddingRow(object sender, GridViewRowCancelEventArgs e)
        {
            if (CheckValidation() == false)
                e.Cancel = true;
        }
        private void gridEmployees_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            Employee newEmployee = new Employee();
            newEmployee.FirstName = Helper.ConvertToString(e.Row.Cells["FirstName"].Value);
            newEmployee.LastName = Helper.ConvertToString(e.Row.Cells["LastName"].Value);
            newEmployee.NickName = Helper.ConvertToString(e.Row.Cells["NickName"].Value);
            newEmployee.Birthday = Helper.ConvertToDate(Helper.ConvertToString(e.Row.Cells["Birthday"].Value));
            newEmployee.BirthLocation = Helper.ConvertToString(e.Row.Cells["BirthLocation"].Value);
            if (Helper.ConvertToInt(Helper.ConvertToString(e.Row.Cells["DeptID"].Value)) > 0)
                newEmployee.DeptID = Helper.ConvertToInt(Helper.ConvertToString(e.Row.Cells["DeptID"].Value));
            newEmployee.Address = Helper.ConvertToString(e.Row.Cells["Address"].Value);
            newEmployee.Phone = Helper.ConvertToString(e.Row.Cells["Phone"].Value);
            newEmployee.Email = Helper.ConvertToString(e.Row.Cells["Email"].Value);
            newEmployee.Website = Helper.ConvertToString(e.Row.Cells["Website"].Value);
            newEmployee.IDNo = Helper.ConvertToString(e.Row.Cells["IDNo"].Value);
            newEmployee.IDIssuedDate = Helper.ConvertToDate(Helper.ConvertToString(e.Row.Cells["IDIssuedDate"].Value));
            newEmployee.IDIssuer = Helper.ConvertToString(e.Row.Cells["IDIssuer"].Value);
            newEmployee.PassportNo = Helper.ConvertToString(e.Row.Cells["PassportNo"].Value);
            newEmployee.PassportIssuedDate = Helper.ConvertToDate(Helper.ConvertToString(e.Row.Cells["PassportIssuedDate"].Value));
            newEmployee.PassportExpiredDate = Helper.ConvertToDate(Helper.ConvertToString(e.Row.Cells["PassportExpiredDate"].Value));
            newEmployee.PassportIssuer = Helper.ConvertToString(e.Row.Cells["PassportIssuer"].Value);
            if (Helper.ConvertToString(e.Row.Cells["Active"].Value) != string.Empty)
                newEmployee.Active = (bool)e.Row.Cells["Active"].Value;
            else newEmployee.Active = false;
            newEmployee.Notes = Helper.ConvertToString(e.Row.Cells["Notes"].Value); 
            newEmployee.CreatedDate = DateTime.Now;
            newEmployee.UpdatedDate = DateTime.Now;

            EQ_MainForm.dbContext.Employees.Add(newEmployee);
            EQ_MainForm.dbContext.SaveChanges();
            InitData(); // rebound datasource
            Helper.ShowInformation("A new EMPLOYEE has been created under line " + (e.Row.Index + 1).ToString());
        }

        private void gridEmployees_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            if (Helper.ShowQuestion("Are you sure to delete this item?") != DialogResult.Yes)
                e.Cancel = true;
        }
        private void gridEmployees_UserDeletedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            //Helper.ShowInformation("gridEmployees_UserDeletedRow");
            Employee currentEmployee = new Employee();
            currentEmployee = (Employee)e.Row.DataBoundItem;
            if (currentEmployee != null)
            {
                EQ_MainForm.dbContext.Employees.Remove(currentEmployee);
                EQ_MainForm.dbContext.SaveChanges();
            }
        }

        private void gridEmployees_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (dataBindingCompleted && e.RowIndex >= 0)
            {
                //Helper.ShowInformation("gridEmployees_CellValueChanged at: " + (e.RowIndex + 1).ToString());                
                Employee currentEmployee = new Employee();
                currentEmployee = (Employee)e.Row.DataBoundItem;
                if (currentEmployee != null)
                {
                    switch (gridEmployees.CurrentColumn.Name)
                    {
                        case "FirstName":
                            currentEmployee.FirstName = Helper.ConvertToString(e.Row.Cells["FirstName"].Value);
                            break;
                        case "LastName":
                            currentEmployee.LastName = Helper.ConvertToString(e.Row.Cells["LastName"].Value);
                            break;
                        case "NickName":
                            currentEmployee.NickName = Helper.ConvertToString(e.Row.Cells["NickName"].Value);
                            break;
                        case "Birthday":
                            currentEmployee.Birthday = Helper.ConvertToDate(Helper.ConvertToString(e.Row.Cells["Birthday"].Value));
                            break;
                        case "BirthLocation":
                            currentEmployee.BirthLocation = Helper.ConvertToString(e.Row.Cells["BirthLocation"].Value);
                            break;
                        case "DeptID":
                            if (Helper.ConvertToInt(Helper.ConvertToString(e.Row.Cells["DeptID"].Value)) > 0)
                              currentEmployee.DeptID = Helper.ConvertToInt(Helper.ConvertToString(e.Row.Cells["DeptID"].Value));
                            break;
                        case "Address":
                            currentEmployee.Address = Helper.ConvertToString(e.Row.Cells["Address"].Value);
                            break;
                        case "Phone":
                            currentEmployee.Phone = Helper.ConvertToString(e.Row.Cells["Phone"].Value);
                            break;
                        case "Email":
                            currentEmployee.Email = Helper.ConvertToString(e.Row.Cells["Email"].Value);
                            break;
                        case "Website":
                            currentEmployee.Website = Helper.ConvertToString(e.Row.Cells["Website"].Value);
                            break;
                        case "IDNo":
                            currentEmployee.IDNo = Helper.ConvertToString(e.Row.Cells["IDNo"].Value);
                            break;
                        case "IDIssuedDate":
                            currentEmployee.IDIssuedDate = Helper.ConvertToDate(Helper.ConvertToString(e.Row.Cells["IDIssuedDate"].Value));
                            break;
                        case "IDIssuer":
                            currentEmployee.IDIssuer = Helper.ConvertToString(e.Row.Cells["IDIssuer"].Value);
                            break;
                        case "PassportNo":
                            currentEmployee.PassportNo = Helper.ConvertToString(e.Row.Cells["PassportNo"].Value);
                            break;
                        case "PassportIssuedDate":
                            currentEmployee.PassportIssuedDate = Helper.ConvertToDate(Helper.ConvertToString(e.Row.Cells["PassportIssuedDate"].Value));
                            break;
                        case "PassportExpiredDate":
                            currentEmployee.PassportExpiredDate = Helper.ConvertToDate(Helper.ConvertToString(e.Row.Cells["PassportExpiredDate"].Value));
                            break;
                        case "PassportIssuer":
                            currentEmployee.PassportIssuer = Helper.ConvertToString(e.Row.Cells["PassportIssuer"].Value);
                            break;
                        case "Active":
                            currentEmployee.Active = (bool)e.Row.Cells["Active"].Value;
                            break;
                        case "Notes":
                            currentEmployee.Notes = Helper.ConvertToString(e.Row.Cells["Notes"].Value);
                            break;
                        default : break;
                    }
                    currentEmployee.UpdatedDate = DateTime.Now;
                    EQ_MainForm.dbContext.SaveChanges();
                }
            }
        }

        private void gridEmployees_CellValidating(object sender, Telerik.WinControls.UI.CellValidatingEventArgs e)
        {
            if (e.RowIndex < 0)  // Don't check if it's the new adding row
                return;
            switch (gridEmployees.CurrentColumn.Name)
            {
                case "FirstName":
                    // First name cannot be empty
                    if (Helper.ConvertToString(e.Value) == string.Empty)
                    {
                        Helper.ShowError("Input the First Name of Employee.");
                        e.Cancel = true;
                    }
                    break;
                case "LastName":
                    // Last Name cannot be empty
                    if (Helper.ConvertToString(e.Value) == string.Empty)
                    {
                        Helper.ShowError("Input the Last Name of Employee.");
                        e.Cancel = true;
                    }
                    break;
                default:
                    break;
            }
        }


    }
}
