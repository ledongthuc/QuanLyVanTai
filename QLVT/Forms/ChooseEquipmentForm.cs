using PGS.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PGS.Forms
{
    public partial class ChooseEquipmentForm : Form
    {
        public ChooseEquipmentForm()
        {
            InitializeComponent();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            CultureSingleton.Instance.ChangeLanguage(this, Thread.CurrentThread.CurrentCulture);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
