using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PGS.Utils;
using System.Threading;

namespace PGS.Controls
{
    public partial class LanguageControl : UserControl
    {
        public LanguageControl()
        {
            InitializeComponent();
        }

        private void btnVN_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = Culture.VI_VN;
            Thread.CurrentThread.CurrentUICulture = Culture.VI_VN;
            CultureSingleton.Instance.ChangeLanguage(Form.ActiveForm, Culture.VI_VN);
        }

        private void btnEN_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = Culture.EN_US;
            Thread.CurrentThread.CurrentUICulture = Culture.EN_US;
            CultureSingleton.Instance.ChangeLanguage(Form.ActiveForm, Culture.EN_US);
        }
    }
}
