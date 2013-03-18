using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using PGS.Entity;

namespace PGS.Controls
{
    public class RequestListBox : UserControl
    {
        private PGS.Entity.PGSDBEntities dbContext = EQ_MainForm.dbContext;
        private RadTextBox txtCodes;
        private RadButton radButton1;
        private RadGridView requestListGridView;
        public delegate void SelectedRequestsChanged();
        public event SelectedRequestsChanged SelectedRequestsChangedHandler;
        public RequestListBox()
        {
            InitializeComponent();
        }
        private void InitRequestGridView()
        {
            requestListGridView = new RadGridView();
            GridViewCheckBoxColumn chkcolumn = new GridViewCheckBoxColumn("SelectedItem");
            requestListGridView.Columns.Add(chkcolumn);            
            GridViewTextBoxColumn column = new GridViewTextBoxColumn("Code");
            requestListGridView.Columns.Add(column);
            column = new GridViewTextBoxColumn("Date");
            column.FormatString = "{0:dd/MM/yyyy}";
            requestListGridView.Columns.Add(column);
            column = new GridViewTextBoxColumn("Notes");
            requestListGridView.Columns.Add(column);
            requestListGridView.DataSource = dbContext.EQ_Requests.ToList<EQ_Requests>();
            requestListGridView.Width = 200;
            requestListGridView.Height = 300;
            requestListGridView.Left = this.Left;
            requestListGridView.Top = this.Bottom;
            requestListGridView.Visible = true;
            requestListGridView.MultiSelect = true;
        }

        
        public void LoadItems()
        {
        }

        private void InitializeComponent()
        {
            this.txtCodes = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodes
            // 
            this.txtCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodes.Location = new System.Drawing.Point(3, 3);
            this.txtCodes.Name = "txtCodes";
            this.txtCodes.Size = new System.Drawing.Size(208, 20);
            this.txtCodes.TabIndex = 1;
            this.txtCodes.TabStop = false;
            // 
            // radButton1
            // 
            this.radButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton1.Location = new System.Drawing.Point(217, 2);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(39, 20);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "v";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // RequestListBox
            // 
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.txtCodes);
            this.Name = "RequestListBox";
            this.Size = new System.Drawing.Size(256, 24);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public string SelectedRequestCodes
        {
            get
            {
                return this.txtCodes.Text;
            }
            set
            {

            }
        }
        public List<EQ_Requests> SelectedRequests
        {
            get
            {
                List<EQ_Requests> kq = new List<EQ_Requests>();
                if (requestListGridView != null)
                {
                    SelectRequestFromCodes();
                    foreach (GridViewRowInfo row in requestListGridView.Rows)
                    {
                        if ((bool)(row.Cells[0].Value) == true)
                        {
                            kq.Add(row.DataBoundItem as EQ_Requests);
                        }
                    }
                }
                return kq;
            }
        }
        private void SelectRequestFromCodes()
        {
            string[] M = txtCodes.Text.Split(',');
            foreach (GridViewRowInfo row in requestListGridView.Rows)
            {
                //row.IsSelected = false;
                row.Cells[0].Value = false;
            }
            foreach (string s in M)
            {
                if (s.Trim() != string.Empty)
                {
                    foreach (GridViewRowInfo row in requestListGridView.Rows)
                    {
                        if (row.Cells[1].Value.ToString() == s.Trim())
                        {
                            //row.IsSelected = true;
                            row.Cells[0].Value = true;
                        }
                    }
                }
            }
        }
        private bool isShowingGridView = false;
        private void radButton1_Click(object sender, EventArgs e)
        {
            isShowingGridView = !isShowingGridView;
            if (isShowingGridView == true)
            {
                radButton1.Text = "^";
                if (requestListGridView == null)
                {
                    InitRequestGridView();
                }
                this.Parent.Controls.Add(requestListGridView);
                this.Parent.Controls.SetChildIndex(requestListGridView, 0);
                SelectRequestFromCodes();
            }
            else
            {
                radButton1.Text = "v";
                this.Parent.Controls.Remove(requestListGridView);
                string codes = string.Empty;
                foreach (GridViewRowInfo row in requestListGridView.Rows)
                {
                    if ((bool)row.Cells[0].Value == true)
                    {
                        codes += row.Cells[1].Value.ToString() + ",";
                    }
                }
                if (codes.Length > 0)
                    codes = codes.Substring(0, codes.Length - 1);
                if (txtCodes.Text.Trim() != codes)
                {
                    txtCodes.Text = codes;
                    if (SelectedRequestsChangedHandler != null)
                        SelectedRequestsChangedHandler();
                }
            }
        }
    }
}
