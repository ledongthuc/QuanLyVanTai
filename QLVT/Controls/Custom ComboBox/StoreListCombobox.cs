using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using PGS.Entity;

namespace PGS.Controls
{
    class StoreListCombobox : RadDropDownList
    {
        private PGS.Entity.PGSDBEntities dbContext = EQ_MainForm.dbContext;
        public void LoadItems()
        {
            this.DropDownStyle = RadDropDownStyle.DropDown;
            List<Store> list = dbContext.Stores.ToList<Store>();
            this.DataSource = list;
            this.DisplayMember = "StoreName";
            this.ValueMember = "Store_ID";
        }

        public Store SelectedStore 
        {
            get
            {
                if (this.SelectedIndex >= 0)
                {
                    return this.SelectedItem.DataBoundItem as Store;
                }
                return null;
            }
        }
    }
}
