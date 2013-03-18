using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PGS.Controls
{
    public partial class EQ_BrowseData : UserControl
    {
        public EQ_BrowseData()
        {
            InitializeComponent();
            InitData();
        }

        public void InitData()
        {
            dateDenNgay.Value = DateTime.Today;
            dateTuNgay.Value = DateTime.Today.AddDays(-180);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
