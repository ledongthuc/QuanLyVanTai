using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PGS.Utils;
using PGS.Entity.Models;
using System.Data.Entity;

namespace PGS.Controls
{
    public partial class NEquipmentList : UserControl
    {
        private ActionStatus action = ActionStatus.NONE;

        public NEquipmentList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            PGS.Utils.CultureSingleton.Instance.ChangeLanguage(this.FindForm(), System.Threading.Thread.CurrentThread.CurrentCulture);

            this.DisableFields();
            this.btnSave.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnNew.Enabled = true;

            BindDataToEquipmentGrid();
        }

        private void BindDataToEquipmentGrid()
        {
            using (var db = new PGSDBContext())
            {
                DbSet<Equipment> equipments = db.Equipments;
                equipments.Load();
                this.radGridViewEquipment.DataSource = equipments;
            }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            PGS.Utils.CultureSingleton.Instance.ChangeLanguage(this.FindForm(), System.Threading.Thread.CurrentThread.CurrentCulture);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            this.txtSearch.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.EnableFields();
            this.btnSave.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnNew.Enabled = false;
            this.action = ActionStatus.NEW;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DisableFields();
            this.btnSave.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnNew.Enabled = true;
            action = ActionStatus.UPDATE;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DisableFields();
            this.btnSave.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnNew.Enabled = true;
            this.action = ActionStatus.DELETE;
        }

        private void ResetFields()
        {
            this.pictureBoxImage.ResetText();
            this.txtCode.ResetText();
            this.txtPartNumber.ResetText();
            this.cboReferCode.ResetText();
            this.txtReferCode.ResetText();
            this.txtName.ResetText();
            this.cboStore.ResetText();
            this.txtDescription.ResetText();
            this.cboUnit.ResetText();
            this.cboCategory.ResetText();
            this.txtOrigin.ResetText();
            this.cboParentCode.ResetText();
            this.chkCritical.ResetText();
            this.chkInUse.ResetText();
        }

        private void DisableFields()
        {
            this.pictureBoxImage.Enabled = false;
            this.txtCode.Enabled = false;
            this.txtPartNumber.Enabled = false;
            this.cboReferCode.Enabled = false;
            this.txtReferCode.Enabled = false;
            this.txtName.Enabled = false;
            this.cboStore.Enabled = false;
            this.txtDescription.Enabled = false;
            this.cboUnit.Enabled = false;
            this.cboCategory.Enabled = false;
            this.txtOrigin.Enabled = false;
            this.cboParentCode.Enabled = false;
            this.chkCritical.Enabled = false;
            this.chkInUse.Enabled = false;

            this.ResetFields();
        }

        private void EnableFields()
        {
            this.pictureBoxImage.Enabled = true;
            this.txtCode.Enabled = true;
            this.txtPartNumber.Enabled = true;
            this.cboReferCode.Enabled = true;
            this.txtReferCode.Enabled = true;
            this.txtName.Enabled = true;
            this.cboStore.Enabled = true;
            this.txtDescription.Enabled = true;
            this.cboUnit.Enabled = true;
            this.cboCategory.Enabled = true;
            this.txtOrigin.Enabled = true;
            this.cboParentCode.Enabled = true;
            this.chkCritical.Enabled = true;
            this.chkInUse.Enabled = true;

            this.ResetFields();
        }
    }
}
