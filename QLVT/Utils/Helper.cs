using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
