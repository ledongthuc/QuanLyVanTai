using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using PGS.Entity;
using PGS.Utils;

namespace PGS.Controls
{
    class PriorityCombobox : RadDropDownList
    {
        public PriorityCombobox()
        {

        }
        public void LoadItems()
        {
            this.Items.Clear();

            RadListDataItem item = new RadListDataItem();
            item.Text = "Bình thường";
            item.Value = Priority.BINH_THUONG;
            this.Items.Add(item);

            item = new RadListDataItem();
            item.Text = "Khẩn";
            item.Value = Priority.KHAN;
            this.Items.Add(item);

            item = new RadListDataItem();
            item.Text = "Thượng khẩn";
            item.Value = Priority.THUONG_KHAN;
            this.Items.Add(item);

            this.DropDownStyle = RadDropDownStyle.DropDownList;
            this.SelectedIndex = 0;
        }
        public Priority SelectedPriority
        {
            get
            {
                return (Priority)this.SelectedItem.Value;
            }
        }
    }
}
