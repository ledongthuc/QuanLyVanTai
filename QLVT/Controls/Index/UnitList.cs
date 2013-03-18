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
    public partial class UnitList : UserControl
    {
        bool dataBindingCompleted = false;

        public UnitList()
        {
            InitializeComponent();
            InitData();
        }

        public void InitData()
        {
            dataBindingCompleted = false;
            //this.gridUnits.DataSource = EQ_MainForm.dbContext.Units.ToList<Unit>();
        }

        private void gridUnits_DataBindingComplete(object sender, Telerik.WinControls.UI.GridViewBindingCompleteEventArgs e)
        {
            dataBindingCompleted = true;
        }
        
        private void gridUnits_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
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

            if (Helper.ConvertToString(gridUnits.CurrentRow.Cells["UCode"].Value) == string.Empty)
                arrError.Add("- Input the code for Unit.");
            if (Helper.ConvertToString(gridUnits.CurrentRow.Cells["UName"].Value) == string.Empty)
                arrError.Add("- Input the name of Unit.");

            if (arrError.Count > 0)
            {
                foreach (string s in arrError)
                    errorMsg += s + "\r\n";
                Helper.ShowError(errorMsg);
                return false;
            }
            return true;
        }
        private void gridUnits_UserAddingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            //if (CheckValidation() == false)
            //    e.Cancel = true;
        }  
        private void gridUnits_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            //Unit newUnit = new Unit();
            //newUnit.UCode = Helper.ConvertToString(e.Row.Cells["UCode"].Value);
            //newUnit.UName = Helper.ConvertToString(e.Row.Cells["UName"].Value);
            //newUnit.UGroup = Helper.ConvertToString(e.Row.Cells["UGroup"].Value);
            //if (Helper.ConvertToString(e.Row.Cells["Active"].Value) != string.Empty)
            //    newUnit.Active = (bool)e.Row.Cells["Active"].Value;
            //else newUnit.Active = false;           
            //newUnit.UNotes = Helper.ConvertToString(e.Row.Cells["UNotes"].Value);
            //newUnit.UpdatedDate = DateTime.Now;

            //EQ_MainForm.dbContext.Units.Add(newUnit);
            //EQ_MainForm.dbContext.SaveChanges();
            //InitData();  //to rebound the datasource for the grid (actually the grid doesn't reflect the new created ID of new item)
            //Helper.ShowInformation("A new UNIT has been created under line " + (e.Row.Index + 1).ToString());
        }

        private void gridUnits_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            if (Helper.ShowQuestion("Are you sure to delete this item?") != DialogResult.Yes)
                e.Cancel = true;
        }
        private void gridUnits_UserDeletedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            //Helper.ShowInformation("gridUnits_UserDeletedRow");
            //Unit currentUnit = new Unit();
            //currentUnit = (Unit)e.Row.DataBoundItem;
            //if (currentUnit != null)
            //{
            //    EQ_MainForm.dbContext.Units.Remove(currentUnit);
            //    EQ_MainForm.dbContext.SaveChanges();
            //}
        }

        private void gridUnits_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
   /*         if (dataBindingCompleted && e.RowIndex >= 0)
            {
                //Helper.ShowInformation("gridUnits_CellValueChanged at: " + (e.RowIndex + 1).ToString());
                Unit currentUnit = new Unit();
                //int unitID = Helper.ConvertToInt(Helper.ConvertToString(e.Row.Cells["Unit_ID"].Value));
                currentUnit = (Unit)e.Row.DataBoundItem;
                    //EQ_MainForm.dbContext.Units.FirstOrDefault(u => u.Unit_ID == unitID);
                if (currentUnit != null)
                {
                    switch (gridUnits.CurrentColumn.Name)
                    {
                        case "UCode": 
                            currentUnit.UCode = Helper.ConvertToString(e.Row.Cells["UCode"].Value);
                            break;
                        case "UName":
                            currentUnit.UName = Helper.ConvertToString(e.Row.Cells["UName"].Value);
                            break;
                        case "UGroup":
                            currentUnit.UGroup = Helper.ConvertToString(e.Row.Cells["UGroup"].Value);
                            break;
                        case "Active":
                            currentUnit.Active = (bool)e.Row.Cells["Active"].Value;
                            break;
                        case "UNotes" :
                            currentUnit.UNotes = Helper.ConvertToString(e.Row.Cells["UNotes"].Value);
                            break;
                        default:
                            break;
                    }
                    currentUnit.UpdatedDate = DateTime.Now;
                    EQ_MainForm.dbContext.SaveChanges();
                }
            } */
        }

        private void gridUnits_CellValidating(object sender, Telerik.WinControls.UI.CellValidatingEventArgs e)
        {
            if (e.RowIndex < 0)  // Don't check if it's the new adding row
                return;
   /*         switch (gridUnits.CurrentColumn.Name)
            {
                case "UCode":
                    string uCode = Helper.ConvertToString(e.Value);
                    // Code cannot be empty
                    if (uCode == string.Empty) 
                    {
                        Helper.ShowError("Input the code for Unit.");
                        e.Cancel = true;
                    }
                    else
                    {                     
                        string oldCode = Helper.ConvertToString(e.OldValue);
                        // If a new code is input
                        if (uCode != oldCode)
                        {
                            Unit currentUnit = EQ_MainForm.dbContext.Units.FirstOrDefault(u => u.UCode == uCode);
                            if (currentUnit != null) // Code is already existed
                            {
                                Helper.ShowError("The code is already existed. Input another code.");
                                e.Cancel = true;
                            }
                        }
                    }
                    break;
                case "UName":
                    // Name cannot be empty
                    if (Helper.ConvertToString(e.Value) == string.Empty)
                    {
                        Helper.ShowError("Input the name of Unit.");
                        e.Cancel = true;
                    }
                    break;
                default: 
                    break;
            } */
        }
        
    }
}
