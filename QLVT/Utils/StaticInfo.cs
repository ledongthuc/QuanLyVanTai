using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PGS.Utils
{
    public class StaticInfo
    {
        public StaticInfo()
		{
			//
			// TODO: Add constructor logic here
			//
		}
        public static string SystemLabel = "EQUIPMENT/TOOLS/CONSUMABLES MANAGEMENT SOFTWARE";

        public static string EquipmentLabel = "EQUIPMENT/TOOLS/CONSUMABLES MANAGEMENT SOFTWARE ";
        public static string MaterialLabel = "MATERIALS MANAGEMENT SOFTWARE ";
        public static string CarLabel = "CAR-USING MANAGEMENT SOFTWARE ";
    }

    public enum Report_Type : int
    {
        NONE = 0,  // No report
        EQ_OrderDetail = 1,
        Mat_OrderByDiv = 2,
        EQ_OrderBySup = 3
    }
    public enum RequestStatus
    {
        CHUA_DUOC_DUYET = 0,
        DA_DUOC_DUYET,
        DA_LAM_DDH,
        DA_NHAP_KHO,
        KET_THUC
    }
    public enum OrderStatus 
    {
        CHO_NHAP_HANG = 0,
        KET_THUC
    }

    public enum Priority
    {
        BINH_THUONG = 0,
        KHAN,
        THUONG_KHAN
    }

    public class Culture
    {
        public static string VI_VN = "vi-VN";
        public static string EN_US = "en-US";
    }
}
