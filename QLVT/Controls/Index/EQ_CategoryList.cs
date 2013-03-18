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
    public partial class EQ_CategoryList : UserControl
    {
        bool dataBindingCompleted = false;

        public EQ_CategoryList()
        {
            InitializeComponent();
            InitData();
        }

        public void InitData()
        {
            dataBindingCompleted = false;
            //this.gridEQCategory.DataSource = EQ_MainForm.dbContext.EQ_Categories.ToList<EQ_Categories>();
        }

        private void gridEQCategory_DataBindingComplete(object sender, Telerik.WinControls.UI.GridViewBindingCompleteEventArgs e)
        {
            dataBindingCompleted = true;
        }

        private void gridEQCategory_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
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

            if (Helper.ConvertToString(gridEQCategory.CurrentRow.Cells["Code"].Value) == string.Empty)
                arrError.Add("- Input the code for Equipment Category.");
            if (Helper.ConvertToString(gridEQCategory.CurrentRow.Cells["Name"].Value) == string.Empty)
                arrError.Add("- Input the name of Equipment Category.");

            if (arrError.Count > 0)
            {
                foreach (string s in arrError)
                    errorMsg += s + "\r\n";
                Helper.ShowError(errorMsg);
                return false;
            }
            return true;
        }
        private void gridEQCategory_UserAddingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            //if (CheckValidation() == false)
            //    e.Cancel = true;
        }
        private void gridEQCategory_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            //EQ_Categories newEQCategory = new EQ_Categories();
            //newEQCategory.Code = Helper.ConvertToString(e.Row.Cells["Code"].Value);
            //newEQCategory.Name = Helper.ConvertToString(e.Row.Cells["Name"].Value);
            //newEQCategory.Description = Helper.ConvertToString(e.Row.Cells["Description"].Value);
            //if (Helper.ConvertToString(e.Row.Cells["Active"].Value) != string.Empty)
            //    newEQCategory.Active = (bool)e.Row.Cells["Active"].Value;
            //else newEQCategory.Active = false;
            //newEQCategory.UpdatedDate = DateTime.Now;

            //EQ_MainForm.dbContext.EQ_Categories.Add(newEQCategory);
            //EQ_MainForm.dbContext.SaveChanges();
            //InitData(); // rebound datasource
            //Helper.ShowInformation("A new Equipment CATEGORY has been created under line " + (e.Row.Index + 1).ToString());
        }

        private void gridEQCategory_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            if (Helper.ShowQuestion("Are you sure to delete this item?") != DialogResult.Yes)
                e.Cancel = true;
        }
        private void gridEQCategory_UserDeletedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            //Helper.ShowInformation("gridEQCategory_UserDeletedRow");
            //EQ_Categories currentEQCategory = new EQ_Categories();
            //currentEQCategory = (EQ_Categories)e.Row.DataBoundItem;
            //if (currentEQCategory != null)
            //{
            //    EQ_MainForm.dbContext.EQ_Categories.Remove(currentEQCategory);
            //    EQ_MainForm.dbContext.SaveChanges();
            //}
        }

        private void gridEQCategory_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            //if (dataBindingCompleted && e.RowIndex >= 0)
            //{
            //    //Helper.ShowInformation("gridEQCategory_CellValueChanged at: " + (e.RowIndex + 1).ToString());
            //    EQ_Categories currentEQCategory = new EQ_Categories();
            //    currentEQCategory = (EQ_Categories)e.Row.DataBoundItem;
            //    if (currentEQCategory != null)
            //    {
            //        switch (gridEQCategory.CurrentColumn.Name)
            //        {
            //            case "Code":
            //                currentEQCategory.Code = Helper.ConvertToString(e.Row.Cells["Code"].Value);
            //                break;
            //            case "Name":
            //                currentEQCategory.Name = Helper.ConvertToString(e.Row.Cells["Name"].Value);
            //                break;
            //            case "Description":
            //                currentEQCategory.Description = Helper.ConvertToString(e.Row.Cells["Description"].Value);
            //                break;
            //            case "Active":
            //                currentEQCategory.Active = (bool)e.Row.Cells["Active"].Value;
            //                break;
            //            default:
            //                break;
            //        }
            //        currentEQCategory.UpdatedDate = DateTime.Now;
            //        EQ_MainForm.dbContext.SaveChanges();
            //    }
            //}
        }

        private void gridEQCategory_CellValidating(object sender, Telerik.WinControls.UI.CellValidatingEventArgs e)
        {
            if (e.RowIndex < 0)  // Don't check if it's the new adding row
                return;
            //switch (gridEQCategory.CurrentColumn.Name)
            //{
            //    case "Code":
            //        string eqcCode = Helper.ConvertToString(e.Value);
            //        // Code cannot be empty
            //        if (eqcCode == string.Empty)
            //        {
            //            Helper.ShowError("Input the code for Equipment Category.");
            //            e.Cancel = true;
            //        }
            //        else
            //        {
            //            string oldCode = Helper.ConvertToString(e.OldValue);
            //            // If a new code is input
            //            if (eqcCode != oldCode)
            //            {
            //                EQ_Categories currentEQCategory = EQ_MainForm.dbContext.EQ_Categories.FirstOrDefault(eqc => eqc.Code == eqcCode);
            //                if (currentEQCategory != null) // Code is already existed
            //                {
            //                    Helper.ShowError("The code is already existed. Input another code.");
            //                    e.Cancel = true;
            //                }
            //            }
            //        }
            //        break;
            //    case "Name":
            //        // Name cannot be empty
            //        if (Helper.ConvertToString(e.Value) == string.Empty)
            //        {
            //            Helper.ShowError("Input the name of Equipment Category.");
            //            e.Cancel = true;
            //        }
            //        break;
            //    default:
            //        break;
            //}
        }

    }
}
