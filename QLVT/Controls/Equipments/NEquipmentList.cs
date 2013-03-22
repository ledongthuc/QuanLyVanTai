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
    public partial class NEquipmentList : UserControl
    {
        public NEquipmentList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            PGS.Utils.CultureSingleton.Instance.ChangeLanguage(this.FindForm(), System.Threading.Thread.CurrentThread.CurrentCulture);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            PGS.Utils.CultureSingleton.Instance.ChangeLanguage(this.FindForm(), System.Threading.Thread.CurrentThread.CurrentCulture);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

    }
}
