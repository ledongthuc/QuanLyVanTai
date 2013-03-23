using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PGS.Entity;
using PGS.Utils;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

namespace PGS.Controls
{
    public partial class UserList : UserControl
    {
        bool dataBindingCompleted = false;
        private bool maNhanVienColumnAdded = false;
        private bool newuserAdding = false;

        public UserList()
        {
            InitializeComponent();
            InitData();
            AddCommboboxex();
        }

        public void InitData()
        {
            dataBindingCompleted = false;
            this.gridUsers.DataSource = EQ_MainForm.dbContext.Users.ToList<User>();
            this.gridUsers.TableElement.RowHeight = 40;
        }

        private void AddCommboboxex()
        {
            GridViewMultiComboBoxColumn column = this.gridUsers.Columns["FullName"] as GridViewMultiComboBoxColumn;
            column.DataSource = EQ_MainForm.dbContext.Employees.Where(e => e.Active == true).ToList<Employee>();
            column.DisplayMember = "FullName";
            column.ValueMember = "Employee_ID";
            
            GridViewComboBoxColumn column1 = this.gridUsers.Columns["DeptID"] as GridViewComboBoxColumn;
            column1.DataSource = EQ_MainForm.dbContext.Departments.Where(d => d.Active == true).ToList<Department>();
            column1.DisplayMember = "DeptName";
            column1.ValueMember = "DeptID";
        }

        private void gridUsers_DataBindingComplete(object sender, GridViewBindingCompleteEventArgs e)
        {
            dataBindingCompleted = true;
        }

        private void gridUsers_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.ColumnInfo.Name == "No" && string.IsNullOrEmpty(e.CellElement.Text))
            {
                e.CellElement.Text = (e.CellElement.RowIndex + 1).ToString();
            }
            if (e.CellElement.ColumnInfo.Name == "FullName")
            {
                if (e.CellElement.Value != null)
                {
                    int id = int.Parse(e.CellElement.Value.ToString());
                    Employee selectedEmployee = EQ_MainForm.dbContext.Employees.FirstOrDefault(em => em.Employee_ID == id);
                    if (selectedEmployee != null)
                        e.CellElement.Text = selectedEmployee.FirstName + " " + selectedEmployee.LastName;
                }
            }
            if (e.CellElement.ColumnInfo.Name == "UserRoles")
            {
                if (e.CellElement.Value != null)
                {
                    int id = (int)e.CellElement.RowInfo.Cells["UserID"].Value;
                    List<UserRole> listUserRole = EQ_MainForm.dbContext.UserRoles.Where(ur => ur.UserID == id).ToList<UserRole>();
                    string strUserRoles = "";
                    for (int i = 0; i < listUserRole.Count; i++)
                    {
                        strUserRoles += listUserRole[i].Role.RoleName + "; ";
                    }
                    e.CellElement.Text = strUserRoles;
                }
            }
        }
        
        private void gridUsers_UserAddingRow(object sender, GridViewRowCancelEventArgs e)
        {
            newuserAdding = true;
            if (Helper.ConvertToString(gridUsers.CurrentRow.Cells["UserName"].Value) == string.Empty)
            {
                Helper.ShowError("Input the username of new account.");
                e.Cancel = true;
            }
            newuserAdding = false;
        }
        private void gridUsers_UserAddedRow(object sender, GridViewRowEventArgs e)
        {
            User newUser = new User();
            if (Helper.ConvertToInt(Helper.ConvertToString(e.Row.Cells["EmployeeID"].Value)) > 0)
                newUser.EmployeeID = Helper.ConvertToInt(Helper.ConvertToString(e.Row.Cells["EmployeeID"].Value));
            newUser.UserName = Helper.ConvertToString(e.Row.Cells["UserName"].Value);
            newUser.UserPwd = Helper.ConvertToString(e.Row.Cells["UserPwd"].Value);
            if (Helper.ConvertToInt(Helper.ConvertToString(e.Row.Cells["DeptID"].Value)) > 0)
                newUser.DeptID = Helper.ConvertToInt(Helper.ConvertToString(e.Row.Cells["DeptID"].Value));
            newUser.UserPosition = Helper.ConvertToString(e.Row.Cells["UserPosition"].Value);
            newUser.UserNotes = Helper.ConvertToString(e.Row.Cells["UserNotes"].Value);
            if (Helper.ConvertToString(e.Row.Cells["IsLogin"].Value) != string.Empty)
                newUser.IsLogin = (bool)e.Row.Cells["IsLogin"].Value;
            else newUser.IsLogin = false;
            if (Helper.ConvertToString(e.Row.Cells["Active"].Value) != string.Empty)
                newUser.Active = (bool)e.Row.Cells["Active"].Value;
            else newUser.Active = false;
            newUser.UpdatedDate = DateTime.Now;

            EQ_MainForm.dbContext.Users.Add(newUser);
            EQ_MainForm.dbContext.SaveChanges();
            InitData(); // Rebound datasource
            Helper.ShowInformation("A new USER has been created under line " + (e.Row.Index + 1).ToString());
        }

        private void gridUsers_UserDeletingRow(object sender, GridViewRowCancelEventArgs e)
        {
            if (Helper.ShowQuestion("Are you sure to delete this item?") != DialogResult.Yes)
                e.Cancel = true;
        }
        private void gridUsers_UserDeletedRow(object sender, GridViewRowEventArgs e)
        {
            //Helper.ShowInformation("gridUsers_UserDeletedRow");
            User currentUser = new User();
            currentUser = (User)e.Row.DataBoundItem;
            //EQ_MainForm.dbContext.Suppliers.FirstOrDefault(s => s.SupplierID == supplierID);
            if (currentUser != null)
            {
                EQ_MainForm.dbContext.Users.Remove(currentUser);
                EQ_MainForm.dbContext.SaveChanges();
            }
        }

        private void gridUsers_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            if (dataBindingCompleted && e.RowIndex >= 0)
            {
                //Helper.ShowInformation("gridUsers_CellValueChanged at: " + (e.RowIndex + 1).ToString());                
                User currentUser = new User();
                currentUser = (User)e.Row.DataBoundItem;
                if (currentUser != null)
                {
                    switch (gridUsers.CurrentColumn.Name)
                    {
                        case "UserName":
                            currentUser.UserName = Helper.ConvertToString(e.Row.Cells["UserName"].Value);
                            break;
                        case "UserPwd":
                            currentUser.UserPwd = Helper.ConvertToString(e.Row.Cells["UserPwd"].Value);
                            break;
                        case "UserPosition":
                            currentUser.UserPosition = Helper.ConvertToString(e.Row.Cells["UserPosition"].Value);
                            break;
                        case "EmployeeID":
                            if (Helper.ConvertToInt(Helper.ConvertToString(e.Row.Cells["EmployeeID"].Value)) > 0)
                                currentUser.EmployeeID = Helper.ConvertToInt(Helper.ConvertToString(e.Row.Cells["EmployeeID"].Value));
                            break;
                        case "DeptID":
                            if (Helper.ConvertToInt(Helper.ConvertToString(e.Row.Cells["DeptID"].Value)) > 0)
                                currentUser.DeptID = Helper.ConvertToInt(Helper.ConvertToString(e.Row.Cells["DeptID"].Value));
                            break;
                        case "Active":
                            currentUser.Active = (bool)e.Row.Cells["Active"].Value;
                            break;
                        case "IsLogin":
                            currentUser.IsLogin = (bool)e.Row.Cells["IsLogin"].Value;
                            break;
                        case "UserNotes":
                            currentUser.UserNotes = Helper.ConvertToString(e.Row.Cells["UserNotes"].Value);
                            break;
                        default: break;
                    }
                    currentUser.UpdatedDate = DateTime.Now;
                    EQ_MainForm.dbContext.SaveChanges();
                }
            }
        }

        private void gridUsers_CellValidating(object sender, CellValidatingEventArgs e)
        {
            if (e.RowIndex < 0)  // Don't check if it's the new adding row
                return;
            switch (gridUsers.CurrentColumn.Name)
            {
                case "UserName":
                    // Name cannot be empty
                    if (Helper.ConvertToString(e.Value) == string.Empty)
                    {
                        Helper.ShowError("Input the username of the account.");
                        e.Cancel = true;
                    }
                    break;
                default:
                    break;
            }
        }

        private void gridUsers_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            if (this.gridUsers.CurrentColumn is GridViewMultiComboBoxColumn)
            {
                if (!maNhanVienColumnAdded)
                {
                    maNhanVienColumnAdded = true;
                    GridViewMultiComboBoxColumn column = this.gridUsers.CurrentColumn as GridViewMultiComboBoxColumn;
                    RadMultiColumnComboBoxElement editor = (RadMultiColumnComboBoxElement)this.gridUsers.ActiveEditor;
                    FilterDescriptor descriptorCode = new FilterDescriptor("FirstName", FilterOperator.StartsWith, string.Empty);
                    editor.EditorControl.FilterDescriptors.Add(descriptorCode);
                    editor.AutoFilter = true;
                    editor.EditorControl.MasterTemplate.AutoGenerateColumns = false;
                    GridViewTextBoxColumn col = new GridViewTextBoxColumn();
                    col.IsVisible = false;
                    col.FieldName = "Employee_ID";
                    editor.EditorControl.Columns.Add(col);//new GridViewTextBoxColumn("Employee_ID"));
                    editor.EditorControl.Columns.Add(new GridViewTextBoxColumn("FirstName"));
                    editor.EditorControl.Columns.Add(new GridViewTextBoxColumn("LastName"));
                    col = new GridViewTextBoxColumn("FullName");
                    editor.EditorControl.Columns.Add(col);
                    col.Expression = "FirstName + ' ' + LastName";
                    editor.EditorControl.Columns.Add(new GridViewTextBoxColumn("Birthday"));
                    editor.AutoSizeDropDownToBestFit = true;

                }
            }
        }

    }
}
