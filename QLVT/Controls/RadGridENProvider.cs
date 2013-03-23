using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;
using Telerik.WinControls;
namespace PGS.Controls
{
    class RadGridENProvider : RadGridLocalizationProvider 
    { 
        public override string GetLocalizedString(string id) 
        { 
            switch (id) 
            {
                case RadGridStringId.FilterOperatorContains: return "Contain";
                case RadGridStringId.FilterFunctionBetween: return "Between"; 
                case RadGridStringId.FilterFunctionDoesNotContain: return "Not contain"; 
                case RadGridStringId.FilterFunctionEndsWith: return "End with"; 
                case RadGridStringId.FilterFunctionEqualTo: return "="; 
                case RadGridStringId.FilterFunctionGreaterThan: return ">"; 
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return ">="; 
                case RadGridStringId.FilterFunctionIsEmpty: return "Is empty"; 
                case RadGridStringId.FilterFunctionIsNull: return "Is null"; 
                case RadGridStringId.FilterFunctionLessThan: return "<"; 
                case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "<="; 
                case RadGridStringId.FilterFunctionNoFilter: return "No filter"; 
                case RadGridStringId.FilterFunctionNotBetween: return "Not between"; 
                case RadGridStringId.FilterFunctionNotEqualTo: return "Not equal"; 
                case RadGridStringId.FilterFunctionNotIsEmpty: return "Is not empty"; 
                case RadGridStringId.FilterFunctionNotIsNull: return "Is not null"; 
                case RadGridStringId.FilterFunctionStartsWith: return "Start with"; 
                case RadGridStringId.FilterFunctionCustom: return "Custom"; 
                case RadGridStringId.CustomFilterDialogCaption: return "Filter Condition:"; 
                case RadGridStringId.CustomFilterDialogLabel: return "Input filter:"; 
                case RadGridStringId.CustomFilterDialogRbAnd: return "And"; 
                case RadGridStringId.CustomFilterDialogRbOr: return "Or"; 
                case RadGridStringId.CustomFilterDialogBtnOk: return "OK";
                case RadGridStringId.CustomFilterDialogBtnCancel: return "Cancel"; 
                case RadGridStringId.AddNewRowString: return "Add new"; 
                default:                    
                    return base.GetLocalizedString(id); 
            } 
        } 
    }
}
