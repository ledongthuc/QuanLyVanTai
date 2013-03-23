using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.Data;
using PGS.Business;
using PGS.Entity;
using PGS.Global;
using Telerik.WinControls.UI.Localization;
namespace PGS.Controls
{
    public partial class NEQ_RequestDetailControl : UserControl
    {
        EQ_Requests currentRequest;
        public EQ_Requests CurrentRequest
        {
            get { return currentRequest; }
            set { currentRequest = value; }
        }

        enum PRIORITY { HIGH = 0, LOW, MEDIUM };

        private bool isEditing = false;
        public bool IsEditing
        {
            get { return isEditing; }
            set { isEditing = value; }
        }

        public NEQ_RequestDetailControl()
        {
            InitializeComponent();
            InitData();
        }

        public void InitData()
        {
            dtRequestDate.Value = DateTime.Today;
            RadGridLocalizationProvider.CurrentProvider = new RadGridENProvider();
        }

        private void NEQ_RequestDetailControl_Load(object sender, EventArgs e)
        {
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            Forms.ChooseEquipmentForm frm = new Forms.ChooseEquipmentForm();
            frm.ShowDialog();
        }

    }
}
