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
    public partial class NEQ_InputDetailControl : UserControl
    {
        public NEQ_InputDetailControl()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            Forms.ChooseEquipmentForm frm = new Forms.ChooseEquipmentForm();
            frm.ShowDialog();
        }
    }
}
