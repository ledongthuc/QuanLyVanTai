using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;
using Telerik.WinControls;
namespace PGS.Controls
{
    class RadGridVNProvider : RadGridLocalizationProvider 
    { 
        public override string GetLocalizedString(string id) 
        { 
            switch (id) 
            {
                case RadGridStringId.FilterOperatorContains: return "Chứa";
                case RadGridStringId.FilterFunctionBetween: return "Giữa"; 
                case RadGridStringId.FilterFunctionContains: return "Chứa"; 
                case RadGridStringId.FilterFunctionDoesNotContain: return "Không chứa"; 
                case RadGridStringId.FilterFunctionEndsWith: return "Kết thúc với"; 
                case RadGridStringId.FilterFunctionEqualTo: return "Bằng"; 
                case RadGridStringId.FilterFunctionGreaterThan: return "Lớn hơn"; 
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Lớn hơn hoặc bằng"; 
                case RadGridStringId.FilterFunctionIsEmpty: return "Là rỗng"; 
                case RadGridStringId.FilterFunctionIsNull: return "Là không tồn tại"; 
                case RadGridStringId.FilterFunctionLessThan: return "Nhỏ hơn"; 
                case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "Nhỏ hơn hoặc bằng"; 
                case RadGridStringId.FilterFunctionNoFilter: return "Không lọc"; 
                case RadGridStringId.FilterFunctionNotBetween: return "Không nằm giữa"; 
                case RadGridStringId.FilterFunctionNotEqualTo: return "Không bằng"; 
                case RadGridStringId.FilterFunctionNotIsEmpty: return "Không rỗng"; 
                case RadGridStringId.FilterFunctionNotIsNull: return "Là tồn tại"; 
                case RadGridStringId.FilterFunctionStartsWith: return "Bắt đầu với"; 
                case RadGridStringId.FilterFunctionCustom: return "Tùy chỉnh"; 
                case RadGridStringId.CustomFilterDialogCaption: return "Hộp thoại điều kiện lọc"; 
                case RadGridStringId.CustomFilterDialogLabel: return "Nhập điều kiện lọc:"; 
                case RadGridStringId.CustomFilterDialogRbAnd: return "Và"; 
                case RadGridStringId.CustomFilterDialogRbOr: return "Hoặc"; 
                case RadGridStringId.CustomFilterDialogBtnOk: return "OK";
                case RadGridStringId.CustomFilterDialogBtnCancel: return "Thoát"; 
                case RadGridStringId.AddNewRowString: return "Thêm mới ở đây"; 
                default:                    
                    return base.GetLocalizedString(id); 
            } 
        } 
    }
}
