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
    class RequestStatusCombobox : RadDropDownList
    {
        public RequestStatusCombobox()
        {

        }
        public void LoadItems()
        {
            this.Items.Clear();

            RadListDataItem item = new RadListDataItem();
            item.Text = "Chưa được duyệt";
            item.Value = RequestStatus.CHUA_DUOC_DUYET;
            this.Items.Add(item);

            item = new RadListDataItem();
            item.Text = "Đã được duyệt";
            item.Value = RequestStatus.DA_DUOC_DUYET;
            this.Items.Add(item);

            item = new RadListDataItem();
            item.Text = "Đã làm đơn đặt hàng";
            item.Value = RequestStatus.DA_LAM_DDH;
            this.Items.Add(item);

            item = new RadListDataItem();
            item.Text = "Đã nhập kho";
            item.Value = RequestStatus.DA_NHAP_KHO;
            this.Items.Add(item);

            item = new RadListDataItem();
            item.Text = "Kết thúc";
            item.Value = RequestStatus.KET_THUC;
            this.Items.Add(item);

            this.DropDownStyle = RadDropDownStyle.DropDownList;
            this.SelectedIndex = 0;
        }
        public RequestStatus SelectedStatus
        {
            get
            {
                return (RequestStatus)this.SelectedItem.Value;
            }
        }
    }
}
