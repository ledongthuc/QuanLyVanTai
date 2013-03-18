using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI.Localization;
using PGS.Entity;
using PGS.Utils;
namespace PGS.Controls
{
    class InputStatusCombobox : RadDropDownList
    {
        public InputStatusCombobox()
        {

        }
        public void LoadItems()
        {
            this.Items.Clear();

            RadListDataItem item = new RadListDataItem();
            item.Text = "Chờ nhập hàng";
            item.Value = OrderStatus.CHO_NHAP_HANG;
            this.Items.Add(item);

            item = new RadListDataItem();
            item.Text = "Kết thúc";
            item.Value = OrderStatus.KET_THUC;
            this.Items.Add(item);
            this.DropDownStyle = RadDropDownStyle.DropDownList;
            this.SelectedIndex = 0;
        }
        public OrderStatus SelectedStatus
        {
            get
            {
                return (OrderStatus)this.SelectedItem.Value;
            }
        }
    }
}
