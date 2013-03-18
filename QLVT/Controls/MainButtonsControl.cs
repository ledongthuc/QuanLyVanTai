using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.Data;
using PGS.Business;
using PGS.Entity;
using PGS.Global;
using Telerik.WinControls.UI.Localization;
namespace PGS.Controls
{
    public partial class MainButtonsControl : UserControl
    {
        public delegate void MainButtonClicked(int value);
        public event MainButtonClicked MainButtonClickedHandler;

        public MainButtonsControl()
        {
            InitializeComponent();
        }

        private void radButton_Click(object sender, EventArgs e)
        {
            if (MainButtonClickedHandler != null)
                MainButtonClickedHandler(int.Parse((((RadButton)sender).Tag.ToString())));
        }

    }
}
