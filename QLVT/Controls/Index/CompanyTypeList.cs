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
    public partial class CompanyTypeList : UserControl
    {
        bool dataBindingCompleted = false;

        public CompanyTypeList()
        {
            InitializeComponent();
            InitData();
        }

        public void InitData()
        {
            dataBindingCompleted = false;
            this.gridCoType.DataSource = EQ_MainForm.dbContext.CoTypes.ToList<CoType>();
        }

        private void gridCoType_DataBindingComplete(object sender, Telerik.WinControls.UI.GridViewBindingCompleteEventArgs e)
        {
            dataBindingCompleted = true;
        }

        private void gridCoType_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
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

            if (Helper.ConvertToString(gridCoType.CurrentRow.Cells["CoCode"].Value) == string.Empty)
                arrError.Add("- Input the code for Company-type.");
            if (Helper.ConvertToString(gridCoType.CurrentRow.Cells["CoName"].Value) == string.Empty)
                arrError.Add("- Input the name of Company-type.");

            if (arrError.Count > 0)
            {
                foreach (string s in arrError)
                    errorMsg += s + "\r\n";
                Helper.ShowError(errorMsg);
                return false;
            }
            return true;
        }
        private void gridCoType_UserAddingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            if (CheckValidation() == false)
                e.Cancel = true;
        }
        private void gridCoType_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            CoType newCoType = new CoType();
            newCoType.CoCode = Helper.ConvertToString(e.Row.Cells["CoCode"].Value);
            newCoType.CoName = Helper.ConvertToString(e.Row.Cells["CoName"].Value);
            newCoType.CoNotes = Helper.ConvertToString(e.Row.Cells["CoNotes"].Value);
            if (Helper.ConvertToString(e.Row.Cells["Active"].Value) != string.Empty)
                newCoType.Active = (bool)e.Row.Cells["Active"].Value;
            else newCoType.Active = false;           
            newCoType.UpdatedDate = DateTime.Now;

            EQ_MainForm.dbContext.CoTypes.Add(newCoType);
            EQ_MainForm.dbContext.SaveChanges();
            InitData(); // rebound datasource
            Helper.ShowInformation("A new COMPANY-TYPE has been created under line " + (e.Row.Index + 1).ToString());
        }

        private void gridCoType_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            if (Helper.ShowQuestion("Are you sure to delete this item?") != DialogResult.Yes)
                e.Cancel = true;
        }
        private void gridCoType_UserDeletedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            //Helper.ShowInformation("gridCoType_UserDeletedRow");
            CoType currentCoType = new CoType();
            currentCoType = (CoType)e.Row.DataBoundItem;
                //EQ_MainForm.dbContext.CoTypes.FirstOrDefault(ct => ct.CoType_ID == cotypeID);
            if (currentCoType != null)
            {
                EQ_MainForm.dbContext.CoTypes.Remove(currentCoType);
                EQ_MainForm.dbContext.SaveChanges();
            }
        }

        private void gridCoType_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (dataBindingCompleted && e.RowIndex >= 0)
            {
                //Helper.ShowInformation("gridCoType_CellValueChanged at: " + (e.RowIndex + 1).ToString());
                CoType currentCoType = new CoType();
                currentCoType = (CoType)e.Row.DataBoundItem;
                if (currentCoType != null)
                {
                    switch (gridCoType.CurrentColumn.Name)
                    {
                        case "CoCode":
                            currentCoType.CoCode = Helper.ConvertToString(e.Row.Cells["CoCode"].Value);
                            break;
                        case "CoName":
                            currentCoType.CoName = Helper.ConvertToString(e.Row.Cells["CoName"].Value);
                            break;
                        case "CoNotes":
                            currentCoType.CoNotes = Helper.ConvertToString(e.Row.Cells["CoNotes"].Value);
                            break;
                        case "Active":
                            currentCoType.Active = (bool)e.Row.Cells["Active"].Value;
                            break;
                        default:
                            break;
                    }
                    currentCoType.UpdatedDate = DateTime.Now;
                    EQ_MainForm.dbContext.SaveChanges();
                }
            }
        }

        private void gridCoType_CellValidating(object sender, Telerik.WinControls.UI.CellValidatingEventArgs e)
        {
            if (e.RowIndex < 0)  // Don't check if it's the new adding row
                return;
            switch (gridCoType.CurrentColumn.Name)
            {
                case "CoCode":
                    string sCode = Helper.ConvertToString(e.Value);
                    // Code cannot be empty
                    if (sCode == string.Empty)
                    {
                        Helper.ShowError("Input the code for Company type.");
                        e.Cancel = true;
                    }
                    else
                    {
                        string oldCode = Helper.ConvertToString(e.OldValue);
                        // If a new code is input
                        if (sCode != oldCode)
                        {
                            CoType currentCoType = EQ_MainForm.dbContext.CoTypes.FirstOrDefault(ct => ct.CoCode == sCode);
                            if (currentCoType != null) // Code is already existed
                            {
                                Helper.ShowError("The code is already existed. Input another code.");
                                e.Cancel = true;
                            }
                        }
                    }
                    break;
                case "CoName":
                    // Name cannot be empty
                    if (Helper.ConvertToString(e.Value) == string.Empty)
                    {
                        Helper.ShowError("Input the name of Company type.");
                        e.Cancel = true;
                    }
                    break;
                default: 
                    break;
            }
        }

    }
}
