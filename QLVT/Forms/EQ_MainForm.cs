using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PGS.Controls;
using PGS.Global;
using PGS.Entity;
using PGS.Forms;
using PGS.Utils;
using System.Threading;

namespace PGS {
    public enum FunctionMode
    {
        None, EQ_AddEditRequest, EQ_ManageRequest, EQ_AddEditQuote, EQ_ManageQuote, EQ_AddEditContract, EQ_ManageContract,
        EQ_AddEditOrder, EQ_ManageOrder, EQ_AddEditInput, EQ_ManageInput, EQ_AddEditOutput, EQ_AddEditDirectOutput, EQ_AddEditInUseOutput, EQ_ManageOutput, 
        EQ_Inventory, EQ_BrowseData, EQ_EquipmentCheck, EQ_EquipmentReport, EQ_RequestRpt, EQ_QuotationRpt, EQ_OrderRpt, EQ_StoreReport,
        Equipment, EQ_Category, Unit, CoType, Supplier, Department, Employee, Role, User, Store, StoreLocation
    };

    public partial class EQ_MainForm : Form {

        public static PGS.Entity.PGSDBEntities dbContext = new PGS.Entity.PGSDBEntities();        

        private FunctionMode currentFunctionMode;

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            CultureSingleton.Instance.ChangeLanguage(this, Thread.CurrentThread.CurrentCulture);
        }

        private FunctionMode CurrentFunctionMode
        {
            get { return currentFunctionMode; }
            set { currentFunctionMode = value; }
        }

        public EQ_MainForm() {
            InitializeComponent();
            //TODO
            radRibbonBarEquipment.Text = Utils.StaticInfo.SystemLabel;
            //AppContext.CurrentUser = dbContext.Users.FirstOrDefault();
            
        }

        private void MainForm_Load(object sender, EventArgs e) 
        {
            AppContext.WorkingDirectory = System.IO.Directory.GetCurrentDirectory();
        }

        private void SetMainControl(Control control)
        {
            if (control is NEQ_OrderDetailControl)
            {
                control.Dock = DockStyle.None;
                control.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            }
            else
            {
                control.Dock = DockStyle.Fill;
            }
            
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(control);
        }
        public void SetActiveRibbonBar(int value)
        {
            //this.radRibbonBarMaterial.Visible = false;
            //this.radRibbonBarCars.Visible = false;
            this.radRibbonBarEquipment.Visible = false;
            if (value == 3)
            {
                this.radRibbonBarEquipment.Visible = true;
            }
            //else if (value == 2)
            //{
            //    this.radRibbonBarCars.Visible = true;
            //}
            //else if (value == 1)
            //{
            //    this.radRibbonBarMaterial.Visible = true;
            //}
        }

        private Control GetMainControlFromFunctionMode(FunctionMode newMode)
        {
            /// Equipment Managmenet
            if (this.currentFunctionMode == FunctionMode.EQ_Inventory)
            {
                EQ_InventoryForm control = new EQ_InventoryForm();
                return control;
            }
            if (this.currentFunctionMode == FunctionMode.EQ_AddEditRequest)
            {
                NEQ_RequestDetailControl control = new NEQ_RequestDetailControl();
                return control;
            }
            if (this.currentFunctionMode == FunctionMode.EQ_ManageRequest)
            {
                NEQ_RequestListControl control = new NEQ_RequestListControl();
                //control.ItemDoubleClicked += new NEQ_RequestListControl.ItemDoubleClickedHandler(RequestListControl_ItemDoubleClicked);
                return control;
            }
            if (this.currentFunctionMode == FunctionMode.EQ_AddEditQuote)
            {
                NEQ_QuoteDetailControl control = new NEQ_QuoteDetailControl();
                return control;
            }
            if (this.currentFunctionMode == FunctionMode.EQ_ManageQuote)
            {
                NEQ_QuoteListControl control = new NEQ_QuoteListControl();
                //control.ItemDoubleClicked += new NEQ_QuoteListControl.ItemDoubleClickedHandler(QuoteListControl_ItemDoubleClicked);
                return control;
            }
            if (this.currentFunctionMode == FunctionMode.EQ_AddEditContract)
            {
                NEQ_ContractDetailControl control = new NEQ_ContractDetailControl();
                return control;
            }
            if (this.currentFunctionMode == FunctionMode.EQ_ManageContract)
            {
                NEQ_ContractListControl control = new NEQ_ContractListControl();
                //control.ItemDoubleClicked += new NEQ_ContractListControl.ItemDoubleClickedHandler(EQ_ContractListControl_ItemDoubleClicked);
                return control;
            }
            if (this.currentFunctionMode == FunctionMode.EQ_AddEditOrder)
            {
                NEQ_OrderDetailControl control = new NEQ_OrderDetailControl();
                return control;
            }
            if (this.currentFunctionMode == FunctionMode.EQ_ManageOrder)
            {
                NEQ_OrderListControl control = new NEQ_OrderListControl();
                //control.ItemDoubleClicked += new NEQ_OrderListControl.ItemDoubleClickedHandler(EQ_OrderListControl_ItemDoubleClicked);
                return control;
            }
            if (this.currentFunctionMode == FunctionMode.EQ_AddEditInput)
            {
                NEQ_InputDetailControl control = new NEQ_InputDetailControl();
                return control;
            }
            if (this.currentFunctionMode == FunctionMode.EQ_ManageInput)
            {
                NEQ_InputListControl control = new NEQ_InputListControl();
                //control.ItemDoubleClicked += new NEQ_InputListControl.ItemDoubleClickedHandler(EQ_InputListControl_ItemDoubleClicked);
                return control;
            }
            if (this.currentFunctionMode == FunctionMode.EQ_AddEditOutput)
            {
                NEQ_OutputDetailControl control = new NEQ_OutputDetailControl();
                return control;
            }
            if (this.currentFunctionMode == FunctionMode.EQ_AddEditDirectOutput)
            {
                NEQ_DirectOutputControl control = new NEQ_DirectOutputControl();
                return control;
            }
            if (this.currentFunctionMode == FunctionMode.EQ_AddEditInUseOutput)
            {
                NEQ_InUseOutputControl control = new NEQ_InUseOutputControl();
                return control;
            }
            if (this.currentFunctionMode == FunctionMode.EQ_ManageOutput)
            {
                NEQ_OutputListControl control = new NEQ_OutputListControl();
                //control.ItemDoubleClicked += new NEQ_OutputListControl.ItemDoubleClickedHandler(EQ_OutputListControl_ItemDoubleClicked);
                return control;
            }

            // For Equipment support
            if (this.currentFunctionMode == FunctionMode.EQ_EquipmentCheck)
                return new EQ_EquipmentCheck();
            if (this.currentFunctionMode == FunctionMode.EQ_BrowseData)
                return new EQ_BrowseData(); 

            /// Hệ thống danh mục
            if (this.currentFunctionMode == FunctionMode.Equipment)
                return new NEquipmentList();
            if (this.currentFunctionMode == FunctionMode.EQ_Category)
                return new EQ_CategoryList();
            if (this.currentFunctionMode == FunctionMode.Unit)
                return new UnitList();
            if (this.currentFunctionMode == FunctionMode.CoType)
                return new CompanyTypeList();
            if (this.currentFunctionMode == FunctionMode.Supplier)
                return new NSupplierList();
            if (this.currentFunctionMode == FunctionMode.Department)
                return new DepartmentList();          
            if (this.currentFunctionMode == FunctionMode.Employee)
                return new EmployeeList();
            if (this.currentFunctionMode == FunctionMode.Role)
                return new RoleList();
            if (this.currentFunctionMode == FunctionMode.User)
                return new UserList();
            if (this.currentFunctionMode == FunctionMode.Store)
                return new NStoreList();
            if (this.currentFunctionMode == FunctionMode.StoreLocation)
                return new NStoreLocationList();
            
            /// For Equipment Reports
            if (this.currentFunctionMode == FunctionMode.EQ_EquipmentReport)
                return new EQ_EquipmentReport(); 
            if (this.currentFunctionMode == FunctionMode.EQ_StoreReport)
                return new EQ_StoreReport();
            if (this.currentFunctionMode == FunctionMode.EQ_RequestRpt)
                return new EQ_RequestReport();
            if (this.currentFunctionMode == FunctionMode.EQ_QuotationRpt)
                return new EQ_QuotationReport();
            if (this.currentFunctionMode == FunctionMode.EQ_OrderRpt)
                return new EQ_OrderReport();
            return null;
        }

        public void ChangeFunctionMode(FunctionMode newMode)
        {
            if (this.currentFunctionMode == newMode)
                return;
            this.CurrentFunctionMode = newMode;
            Control control = GetMainControlFromFunctionMode(newMode);
            SetMainControl(control);
        }

        /// <summary>
        /// Hệ thống Danh Mục
        /// </summary>
        private void btnCoType_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.SystemLabel + " - Company Type";
            ChangeFunctionMode(FunctionMode.CoType);
        }       
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.SystemLabel + " - SUPPLIERS";
            ChangeFunctionMode(FunctionMode.Supplier);
        }
        private void btnSupplier_1_Click(object sender, EventArgs e)
        {
            btnSupplier_Click(sender, e);
        }
        private void btnDepartment_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.MaterialLabel + " - DEPARTMENTS";
            ChangeFunctionMode(FunctionMode.Department);
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.MaterialLabel + " - EMPLOYEES";
            ChangeFunctionMode(FunctionMode.Employee);
        }
        private void btnRole_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.MaterialLabel + " - USER-ROLES";
            ChangeFunctionMode(FunctionMode.Role);
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.MaterialLabel + " - USERS";
            ChangeFunctionMode(FunctionMode.User);
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.SystemLabel + " - UNITS";
            ChangeFunctionMode(FunctionMode.Unit);
        }
        private void btnUnit_1_Click(object sender, EventArgs e)
        {
            btnUnit_Click(sender, e);
        }
        private void btnEQCategory_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - Equipment Categories";
            ChangeFunctionMode(FunctionMode.EQ_Category);
        }
        private void btnEquipment_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - EQUIPMENTS / SPAREPART / TOOLS";
            ChangeFunctionMode(FunctionMode.Equipment);
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - STORES";
            ChangeFunctionMode(FunctionMode.Store);
        }
        private void btnLocation_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - LOCATIONS in STORE";
            ChangeFunctionMode(FunctionMode.StoreLocation);
        }

        /// <summary>
        /// Hệ thống Quy Trình cho Vật Tư (Equipment)
        /// </summary>
        private void btnInventory_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - INVENTORY ";
            ChangeFunctionMode(FunctionMode.EQ_Inventory);
        }

        private void btnPhieuyeucau_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - REQUEST FORM";
            ChangeFunctionMode(FunctionMode.EQ_AddEditRequest);
        }
        private void btnDanhsachyeucau_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - LIST of REQUESTS";
            ChangeFunctionMode(FunctionMode.EQ_ManageRequest);
        }
        private void RequestListControl_ItemDoubleClicked(EQ_Requests request)
        {
            ChangeFunctionMode(FunctionMode.EQ_AddEditRequest);
            NEQ_RequestDetailControl control = mainPanel.Controls[mainPanel.Controls.Count - 1] as NEQ_RequestDetailControl;
            //control.EditRequest(request);
        }

        private void btnPhieuMoiChaoGia_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - QUOTATION FORM";
            ChangeFunctionMode(FunctionMode.EQ_AddEditQuote);
        }
        private void btnDanhSachMoiChaoGia_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - LIST of QUOTATIONS";
            ChangeFunctionMode(FunctionMode.EQ_ManageQuote);
        }
        private void QuoteListControl_ItemDoubleClicked(EQ_Quotes quote)
        {
            ChangeFunctionMode(FunctionMode.EQ_AddEditQuote);
            NEQ_QuoteDetailControl control = mainPanel.Controls[mainPanel.Controls.Count - 1] as NEQ_QuoteDetailControl;
            //control.EditQuote(quote);
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - CONTRACT FORM";
            ChangeFunctionMode(FunctionMode.EQ_AddEditContract);
        }
        private void btnDanhSachHopDong_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - LIST of CONTRACTS";
            ChangeFunctionMode(FunctionMode.EQ_ManageContract);
        }
        private void EQ_ContractListControl_ItemDoubleClicked(EQ_Contracts contract)
        {
            ChangeFunctionMode(FunctionMode.EQ_AddEditContract);
            NEQ_ContractDetailControl control = mainPanel.Controls[mainPanel.Controls.Count - 1] as NEQ_ContractDetailControl;
            //control.EditQuote(contract);
        }
 
        private void btnOrder_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - ORDER FORM";
            ChangeFunctionMode(FunctionMode.EQ_AddEditOrder);
        }
        private void btnDanhSachOrder_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - LIST of ORDERS";
            ChangeFunctionMode(FunctionMode.EQ_ManageOrder);
        }
        private void EQ_OrderListControl_ItemDoubleClicked(EQ_Orders order)
        {
            ChangeFunctionMode(FunctionMode.EQ_AddEditOrder);
            NEQ_OrderDetailControl control = mainPanel.Controls[mainPanel.Controls.Count - 1] as NEQ_OrderDetailControl;
            //control.EditOrder(order);
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - STOCK RECEIVE FORM";
            ChangeFunctionMode(FunctionMode.EQ_AddEditInput);
        }
        private void btnInputList_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - LIST of STOCK RECEIVES";
            ChangeFunctionMode(FunctionMode.EQ_ManageInput);
        }       
        private void EQ_InputListControl_ItemDoubleClicked(EQ_Inputs input)
        {
            ChangeFunctionMode(FunctionMode.EQ_AddEditInput);
            NEQ_InputDetailControl control = mainPanel.Controls[mainPanel.Controls.Count - 1] as NEQ_InputDetailControl;
            //control.EditInput(input);
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - ISSUE STOCK FORM";
            ChangeFunctionMode(FunctionMode.EQ_AddEditOutput);
        }
        private void btnOutputList_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - LIST of ISSUE STOCKS";
            ChangeFunctionMode(FunctionMode.EQ_ManageOutput);
        }       
        private void EQ_OutputListControl_ItemDoubleClicked(EQ_Outputs output)
        {
            ChangeFunctionMode(FunctionMode.EQ_AddEditOutput);
            NEQ_OutputDetailControl control = mainPanel.Controls[mainPanel.Controls.Count - 1] as NEQ_OutputDetailControl;
            //control.EditOutput(output);
        }

        /// <summary>
        /// For Equipment 
        /// </summary>
        private void btnEQ_BrowseData_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - Browse all available data";
            ChangeFunctionMode(FunctionMode.EQ_BrowseData);
        }
        private void btnEquipCheck_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - Check for an requested Equipment";
            ChangeFunctionMode(FunctionMode.EQ_EquipmentCheck);
        }

        private void btnEquipmentReport_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - REPORT about EQUIPMENTS by every Store ";
            ChangeFunctionMode(FunctionMode.EQ_EquipmentReport);
        }
        private void btnEQ_RequestRpt_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - REPORT about REQUESTS ";
            ChangeFunctionMode(FunctionMode.EQ_RequestRpt);
        }
        private void btnEQ_QuotationRpt_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - REPORT about QUOTATIONS ";
            ChangeFunctionMode(FunctionMode.EQ_QuotationRpt);
        }
        private void btnEQ_OrderRpt_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - REPORT about ORDERS / CONTRACTS ";
            ChangeFunctionMode(FunctionMode.EQ_OrderRpt);
        }
        private void btnStoreReport_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - STORE REPORT ";
            ChangeFunctionMode(FunctionMode.EQ_StoreReport);
        }

        private void btnDirectOutput_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - DIRECT ISSUE ";
            ChangeFunctionMode(FunctionMode.EQ_AddEditDirectOutput);
        }
        private void btnInUseOutput_Click(object sender, EventArgs e)
        {
            radRibbonBarEquipment.Text = Utils.StaticInfo.EquipmentLabel + " - IN-USE ISSUE ";
            ChangeFunctionMode(FunctionMode.EQ_AddEditInUseOutput);
        }
    }
}
