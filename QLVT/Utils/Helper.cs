using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;

namespace PGS.Utils
{
    public class Helper
    {
        public Helper()
		{
			//
			// TODO: Add constructor logic here
			//
		}
        public static string FormatNumber(string s)
        {
            string result = s;
            try
            {
                double.Parse(s);
                if (s.IndexOf(',') < 0)
                {
                    int vitriCuoi = s.Length;
                    if (s.IndexOf('.') >= 0)
                    {
                        vitriCuoi = s.IndexOf('.');
                    }
                    for (int i = vitriCuoi - 3; i >= 1; i -= 3)
                    {
                        result = result.Insert(i, ",");
                    }
                }
            }
            catch
            {
                result = s;
            }
            return result;
        }

		public static DialogResult ShowError(string msg)
		{
            return RadMessageBox.Show(msg, "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
		}

		public static DialogResult ShowInformation(string msg)
		{
			return RadMessageBox.Show(msg,"Information", MessageBoxButtons.OK, RadMessageIcon.Info);
                //MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		public static DialogResult ShowQuestion(string msg)
		{
            return RadMessageBox.Show(msg, "Confirm message", MessageBoxButtons.YesNo, RadMessageIcon.Question);
		}

        public static string ConvertToString(object obj)
        {
            try
            {
                return obj.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }		
        
        public static long ConvertToLong(string str)
		{
			try
			{
				if(str.EndsWith(";")) str=str.Trim().Substring(0,str.Length-1);
				return Int64.Parse(str);
			}
			catch
			{
				return -1;
			}
		}
		public static int ConvertToInt(string str)
		{
			try
			{
				if(str.EndsWith(";")) str=str.Trim().Substring(0,str.Length-1);
				return Int32.Parse(str);
			}
			catch
			{
				return -1;
			}
		}
		public static short ConvertToShort(string str)
		{
			try
			{
				if(str.EndsWith(";")) str=str.Trim().Substring(0,str.Length-1);
				return Int16.Parse(str);
			}
			catch
			{
				return -1;
			}
		}
		public static float ConvertToFloat(string str)
		{
			try
			{
				if(str.EndsWith(";")) str=str.Trim().Substring(0,str.Length-1);
				return float.Parse(str);
			}
			catch
			{
				return -1;
			}
		}
		public static double ConvertToDouble(string str)
		{
			try
			{
				if(str.EndsWith(";")) str=str.Trim().Substring(0,str.Length-1);
				return double.Parse(str);
			}
			catch
			{
				return -1;
			}
		}
        public static decimal ConvertToDecimal(string str)
        {
            try
            {
                if (str.EndsWith(";")) str = str.Trim().Substring(0, str.Length - 1);
                return decimal.Parse(str);
            }
            catch
            {
                return -1;
            }
        }

		public static DateTime ConvertToDate(string str)
		{
			try
			{
				if(str.EndsWith(";")) str=str.Trim().Substring(0,str.Length-1);
				return DateTime.Parse(str);
			}
			catch
			{
                return new DateTime(1900,1,1);//DateTime.MaxValue;
			}
		}

		public static bool IsContained(string src, string des, char splitter)
		{
			if(des=="") return true;
			if(!des.EndsWith(splitter.ToString())) des= des + splitter.ToString();
			string[] arr = des.Split(splitter);

			if(!src.StartsWith(splitter.ToString())) src = splitter.ToString() + src;
			if(!src.EndsWith(splitter.ToString())) src = src + splitter.ToString();			

			for(int i=0;i<arr.Length-1;i++)   
			{
				if(src.IndexOf(splitter.ToString()+arr[i]+splitter.ToString())!=-1) return true;
			}
			return false;
		}

        /// <summary>
        /// The function switch current language in application.
        /// </summary>
        /// <param name="culture">The culture will be switched. You can get it from Culture.VI_VN or Culture.EN_US</param>
        /// <returns>The result of switching language</returns>
        public static bool SwitchLanguage(this Form affectForm, string culture)
        {
            try
            {
                string cultureName = Thread.CurrentThread.CurrentCulture.Name;
                if (cultureName.Equals("en-US"))
                {
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
                }
                else if (cultureName.Equals("vi-VN"))
                {
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                }

                ComponentResourceManager resources = new ComponentResourceManager(affectForm.GetType());
                ApplyResourceToControls(affectForm, resources);
            }
            catch
            {
            }

            return false;
        }

        /// Two function allows the method SwitchLanguage can apply new language to all controls in form.
        #region Localization Automatic
        protected static void ApplyResourceToControls(Control parentControl, ComponentResourceManager resource)
        {
            resource.ApplyResources(parentControl, parentControl.Name);

            if (parentControl.HasChildren)
            {
                foreach (Control control in parentControl.Controls)
                {
                    ApplyResourceToControls(control, resource);
                }
            }
            #region Custom control
            //if (parentControl is RadDropDownList)
            //{
            //    if (((RadDropDownList)parentControl).Items.Count > 0)
            //    {
            //        ApplyResourceToDataItem(parentControl, ((RadDropDownList)parentControl).Items, resource, "Items");
            //    }
            //}

            //if (parentControl is RadListControl)
            //{
            //    if (((RadListControl)parentControl).Items.Count > 0)
            //    {
            //        ApplyResourceToDataItem(parentControl, ((RadListControl)parentControl).Items, resource, "Items");
            //    }
            //}

            //if (parentControl is RadDropDownButton)
            //{
            //    if (((RadDropDownButton)parentControl).Items.Count > 0)
            //    {
            //        ApplyResourceToDataItem(parentControl, ((RadDropDownButton)parentControl).Items, resource, "Items");
            //    }
            //}

            //if (parentControl is RadGridView)
            //{
            //    if (((RadGridView)parentControl).Columns.Count > 0)
            //    {
            //        ApplyResourceToDataItem(parentControl, ((RadGridView)parentControl).Columns, resource, "Columns");
            //    }
            //}
            #endregion
        }

        protected static void ApplyResourceToDataItem(Control parentControl, IEnumerable<object> dataItems, ComponentResourceManager resource, string attribute)
        {
            int dataItemIndex = 0;
            foreach (var dataItem in dataItems)
            {
                string resourceName = string.Format("{0}.{1}[{2}]", parentControl.Name, attribute, dataItemIndex);
                dataItemIndex++;
                resource.ApplyResources(dataItem, resourceName);
            }
        }
        #endregion
    }
}
