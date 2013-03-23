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
    public partial class EQ_StoreReport : UserControl
    {
        public EQ_StoreReport()
        {
            InitializeComponent();
            InitData(); 
        }

        public void InitData()
        {
            dtFrom.Value = DateTime.Today;
            dtTo.Value = DateTime.Today.AddDays(-30);
        }
    }
}
