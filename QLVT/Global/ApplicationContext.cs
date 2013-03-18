using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PGS.Entity;
using PGS.Business;
namespace PGS.Global
{
    class AppContext
    {
        private static User currentUser;
        //private static Employee currentEmployee;

        public static User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        public static string WorkingDirectory = "";
    
    }
}
