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
    public partial class RoleList : UserControl
    {
        bool dataBindingCompleted = false;

        public RoleList()
        {
            InitializeComponent();
            InitData();
        }

        public void InitData()
        {
            dataBindingCompleted = false;
            this.gridRoles.DataSource = EQ_MainForm.dbContext.Roles.ToList<Role>();
        }

        private void gridRoles_DataBindingComplete(object sender, Telerik.WinControls.UI.GridViewBindingCompleteEventArgs e)
        {
            dataBindingCompleted = true;
        }

        private void gridRoles_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
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

            if (Helper.ConvertToString(gridRoles.CurrentRow.Cells["RoleCode"].Value) == string.Empty)
                arrError.Add("- Input the code for Role.");
            if (Helper.ConvertToString(gridRoles.CurrentRow.Cells["RoleName"].Value) == string.Empty)
                arrError.Add("- Input the name of Role.");

            if (arrError.Count > 0)
            {
                foreach (string s in arrError)
                    errorMsg += s + "\r\n";
                Helper.ShowError(errorMsg);
                return false;
            }
            return true;
        }
        private void gridRoles_UserAddingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            if (CheckValidation() == false)
                e.Cancel = true;
        }
        private void gridRoles_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            Role newRole = new Role();
            newRole.RoleCode = Helper.ConvertToString(e.Row.Cells["RoleCode"].Value);
            newRole.RoleName = Helper.ConvertToString(e.Row.Cells["RoleName"].Value);
            newRole.Description = Helper.ConvertToString(e.Row.Cells["Description"].Value);
            if (Helper.ConvertToString(e.Row.Cells["Active"].Value) != string.Empty)
                newRole.Active = (bool)e.Row.Cells["Active"].Value;
            else newRole.Active = false;
            newRole.UpdatedDate = DateTime.Now;

            EQ_MainForm.dbContext.Roles.Add(newRole);
            EQ_MainForm.dbContext.SaveChanges();
            InitData(); // rebound datasource
            Helper.ShowInformation("A new ROLE has been created under line " + (e.Row.Index + 1).ToString());
        }

        private void gridRoles_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            if (Helper.ShowQuestion("Are you sure to delete this item?") != DialogResult.Yes)
                e.Cancel = true;
        }
        private void gridRoles_UserDeletedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            //Helper.ShowInformation("gridRoles_UserDeletedRow");
            Role currentRole = new Role();
            currentRole = (Role)e.Row.DataBoundItem;
            if (currentRole != null)
            {
                EQ_MainForm.dbContext.Roles.Remove(currentRole);
                EQ_MainForm.dbContext.SaveChanges();
            }
        }

        private void gridRoles_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (dataBindingCompleted && e.RowIndex >= 0)
            {
                //Helper.ShowInformation("gridRoles_CellValueChanged at: " + (e.RowIndex + 1).ToString());
                Role currentRole = new Role();
                currentRole = (Role)e.Row.DataBoundItem;
                if (currentRole != null)
                {
                    switch (gridRoles.CurrentColumn.Name)
                    {
                        case "RoleCode":
                            currentRole.RoleCode = Helper.ConvertToString(e.Row.Cells["RoleCode"].Value);
                            break;
                        case "RoleName":
                            currentRole.RoleName = Helper.ConvertToString(e.Row.Cells["RoleName"].Value);
                            break;
                        case "Description":
                            currentRole.Description = Helper.ConvertToString(e.Row.Cells["Description"].Value);
                            break;
                        case "Active":
                            currentRole.Active = (bool)e.Row.Cells["Active"].Value;
                            break;
                        default:
                            break;
                    }
                    currentRole.UpdatedDate = DateTime.Now;
                    EQ_MainForm.dbContext.SaveChanges();
                }
            }
        }

        private void gridRoles_CellValidating(object sender, Telerik.WinControls.UI.CellValidatingEventArgs e)
        {
            if (e.RowIndex < 0)  // Don't check if it's the new adding row
                return;
            switch (gridRoles.CurrentColumn.Name)
            {
                case "RoleCode":
                    string rCode = Helper.ConvertToString(e.Value);
                    // Code cannot be empty
                    if (rCode == string.Empty)
                    {
                        Helper.ShowError("Input the code for Role.");
                        e.Cancel = true;
                    }
                    else
                    {
                        string oldCode = Helper.ConvertToString(e.OldValue);
                        // If a new code is input
                        if (rCode != oldCode)
                        {
                            Role currentRole = EQ_MainForm.dbContext.Roles.FirstOrDefault(r => r.RoleCode == rCode);
                            if (currentRole != null) // Code is already existed
                            {
                                Helper.ShowError("The code is already existed. Input another code.");
                                e.Cancel = true;
                            }
                        }
                    }
                    break;
                case "RoleName":
                    // Name cannot be empty
                    if (Helper.ConvertToString(e.Value) == string.Empty)
                    {
                        Helper.ShowError("Input the name of Role.");
                        e.Cancel = true;
                    }
                    break;
                default:
                    break;
            }
        }

    }
}
