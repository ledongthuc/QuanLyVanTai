using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PGS.Entity;
using PGS.Global;
using PGS.Business;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI.Localization;

namespace PGS.Controls
{
    public partial class NEQ_OrderListControl : UserControl
    {
        public NEQ_OrderListControl()
        {
            InitializeComponent();
            InitData();
        }

        public void InitData()
        {
        }

        private void NEQ_OrderListControl_Load(object sender, EventArgs e)
        {
        }
    }
}
