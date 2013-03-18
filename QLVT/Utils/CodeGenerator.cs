using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PGS.Business;
using PGS.Entity;
using PGS.Global;
namespace PGS.Utils
{
    class CodeGenerator
    {
        public static string GenerateRequestCode(int storeID)
        {
            PGSDBEntities dbContext = EQ_MainForm.dbContext;
            string year = DateTime.Now.Year.ToString().Substring(2);
            System.Data.Objects.ObjectResult<int?> maxRequestCodeObjectResult = (dbContext.GetMaxRequestCode(storeID));
            int? maxRequestCodeNumber = maxRequestCodeObjectResult.First();
            int newRequestNumber = 1;
            if (maxRequestCodeNumber.HasValue)
                newRequestNumber = maxRequestCodeNumber.Value + 1;
            string storeCode = dbContext.Stores.First(s => s.Store_ID == storeID).StoreCode;
            return newRequestNumber + storeCode + year;
        }
    }
}
