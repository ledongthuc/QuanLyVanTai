using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PGS.Entity;
using Telerik.WinControls.UI;

namespace PGS.Utils
{
    public class LoadStatic
    {
        public LoadStatic()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static void LoadStatus(ref RadDropDownList cboStatus)
        {
            try
            {
                cboStatus.DisplayMember = "StatusName";
                cboStatus.ValueMember = "Status_ID";
                List<StatusCollection> listStatusCollection = EQ_MainForm.dbContext.StatusCollections.Where(d => d.Active == true).ToList<StatusCollection>();
                StatusCollection emptyStatusCollection = new StatusCollection();
                emptyStatusCollection.Status_ID = 0;
                emptyStatusCollection.StatusName = string.Empty;
                listStatusCollection.Insert(0, emptyStatusCollection);
                cboStatus.DataSource = listStatusCollection;
                cboStatus.SelectedIndex = 0;
            }
            catch //(Exception ex)
            {
                Helper.ShowError("Cannot load the status information!");
            }
        }
 
    }
}
