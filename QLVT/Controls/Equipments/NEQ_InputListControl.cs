﻿using System;
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
    public partial class NEQ_InputListControl : UserControl
    {
        public NEQ_InputListControl()
        {
            InitializeComponent();
            dateDenNgay.Value = DateTime.Today;
            dateTuNgay.Value = DateTime.Today.AddDays(-30);
        }

        private void NEQ_InputListControl_Load(object sender, EventArgs e)
        {
        }
    }
}
