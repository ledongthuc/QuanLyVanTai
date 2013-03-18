using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using PGS.Entity;

namespace PGS.Controls
{
    class DepartmentListCombobox : RadDropDownList
    {
        private PGS.Entity.PGSDBEntities dbContext = EQ_MainForm.dbContext;

        public void LoadItems()
        {
            this.DropDownStyle = RadDropDownStyle.DropDown;
            List<Department> list = dbContext.Departments.ToList<Department>();
            this.DataSource = list;
            this.DisplayMember = "DeptName";
            this.ValueMember = "DeptID";
        }

        public void LoadItemsWBlank()
        {
            this.DropDownStyle = RadDropDownStyle.DropDown;
            List<Department> list = dbContext.Departments.ToList<Department>();
            this.DisplayMember = "DeptName";
            this.ValueMember = "DeptID";
            // Add blank dept to Combobox
            Department emptyDept = new Department();
            emptyDept.DeptID = -1;
            emptyDept.DeptName = string.Empty;
            list.Insert(0, emptyDept);

            this.DataSource = list;
        }

        public Department SelectedDepartment
        {
            get
            {
                if (this.SelectedIndex >= 0)
                {
                    return this.SelectedItem.DataBoundItem as Department;
                }
                return null;
            }
        }

    }
}
