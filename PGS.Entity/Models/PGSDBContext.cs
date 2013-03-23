using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using PGS.Entity.Models.Mapping;

namespace PGS.Entity.Models
{
    public partial class PGSDBContext : DbContext
    {
        static PGSDBContext()
        {
            Database.SetInitializer<PGSDBContext>(null);
        }

        public PGSDBContext()
            : base("Name=PGSDBContext")
        {
        }

        public DbSet<Car_Drivers> Car_Drivers { get; set; }
        public DbSet<Car_Maintenances> Car_Maintenances { get; set; }
        public DbSet<Car_Schedules> Car_Schedules { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CoType> CoTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EQ_Categories> EQ_Categories { get; set; }
        public DbSet<EQ_Contract_Details> EQ_Contract_Details { get; set; }
        public DbSet<EQ_Contract_Requests> EQ_Contract_Requests { get; set; }
        public DbSet<EQ_Contracts> EQ_Contracts { get; set; }
        public DbSet<EQ_Input_Details> EQ_Input_Details { get; set; }
        public DbSet<EQ_Input_Others> EQ_Input_Others { get; set; }
        public DbSet<EQ_Inputs> EQ_Inputs { get; set; }
        public DbSet<EQ_Inventory> EQ_Inventory { get; set; }
        public DbSet<EQ_Inventory_Locations> EQ_Inventory_Locations { get; set; }
        public DbSet<EQ_Order_Details> EQ_Order_Details { get; set; }
        public DbSet<EQ_Order_Requests> EQ_Order_Requests { get; set; }
        public DbSet<EQ_Orders> EQ_Orders { get; set; }
        public DbSet<EQ_Ouput_Inputs> EQ_Ouput_Inputs { get; set; }
        public DbSet<EQ_Output_Details> EQ_Output_Details { get; set; }
        public DbSet<EQ_Outputs> EQ_Outputs { get; set; }
        public DbSet<EQ_Quote_Details> EQ_Quote_Details { get; set; }
        public DbSet<EQ_Quote_Requests> EQ_Quote_Requests { get; set; }
        public DbSet<EQ_Quote_Suppliers> EQ_Quote_Suppliers { get; set; }
        public DbSet<EQ_Quotes> EQ_Quotes { get; set; }
        public DbSet<EQ_Request_Details> EQ_Request_Details { get; set; }
        public DbSet<EQ_Requests> EQ_Requests { get; set; }
        public DbSet<EQ_Stores> EQ_Stores { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Mat_Categories> Mat_Categories { get; set; }
        public DbSet<Mat_Input_Details> Mat_Input_Details { get; set; }
        public DbSet<Mat_Inputs> Mat_Inputs { get; set; }
        public DbSet<Mat_Order_Details> Mat_Order_Details { get; set; }
        public DbSet<Mat_Orders> Mat_Orders { get; set; }
        public DbSet<Mat_Repair_Details> Mat_Repair_Details { get; set; }
        public DbSet<Mat_Repairs> Mat_Repairs { get; set; }
        public DbSet<Mat_Request_Details> Mat_Request_Details { get; set; }
        public DbSet<Mat_Requests> Mat_Requests { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<StatusCollection> StatusCollections { get; set; }
        public DbSet<Store_Locations> Store_Locations { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Car_DriversMap());
            modelBuilder.Configurations.Add(new Car_MaintenancesMap());
            modelBuilder.Configurations.Add(new Car_SchedulesMap());
            modelBuilder.Configurations.Add(new CarMap());
            modelBuilder.Configurations.Add(new CoTypeMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EQ_CategoriesMap());
            modelBuilder.Configurations.Add(new EQ_Contract_DetailsMap());
            modelBuilder.Configurations.Add(new EQ_Contract_RequestsMap());
            modelBuilder.Configurations.Add(new EQ_ContractsMap());
            modelBuilder.Configurations.Add(new EQ_Input_DetailsMap());
            modelBuilder.Configurations.Add(new EQ_Input_OthersMap());
            modelBuilder.Configurations.Add(new EQ_InputsMap());
            modelBuilder.Configurations.Add(new EQ_InventoryMap());
            modelBuilder.Configurations.Add(new EQ_Inventory_LocationsMap());
            modelBuilder.Configurations.Add(new EQ_Order_DetailsMap());
            modelBuilder.Configurations.Add(new EQ_Order_RequestsMap());
            modelBuilder.Configurations.Add(new EQ_OrdersMap());
            modelBuilder.Configurations.Add(new EQ_Ouput_InputsMap());
            modelBuilder.Configurations.Add(new EQ_Output_DetailsMap());
            modelBuilder.Configurations.Add(new EQ_OutputsMap());
            modelBuilder.Configurations.Add(new EQ_Quote_DetailsMap());
            modelBuilder.Configurations.Add(new EQ_Quote_RequestsMap());
            modelBuilder.Configurations.Add(new EQ_Quote_SuppliersMap());
            modelBuilder.Configurations.Add(new EQ_QuotesMap());
            modelBuilder.Configurations.Add(new EQ_Request_DetailsMap());
            modelBuilder.Configurations.Add(new EQ_RequestsMap());
            modelBuilder.Configurations.Add(new EQ_StoresMap());
            modelBuilder.Configurations.Add(new EquipmentMap());
            modelBuilder.Configurations.Add(new Mat_CategoriesMap());
            modelBuilder.Configurations.Add(new Mat_Input_DetailsMap());
            modelBuilder.Configurations.Add(new Mat_InputsMap());
            modelBuilder.Configurations.Add(new Mat_Order_DetailsMap());
            modelBuilder.Configurations.Add(new Mat_OrdersMap());
            modelBuilder.Configurations.Add(new Mat_Repair_DetailsMap());
            modelBuilder.Configurations.Add(new Mat_RepairsMap());
            modelBuilder.Configurations.Add(new Mat_Request_DetailsMap());
            modelBuilder.Configurations.Add(new Mat_RequestsMap());
            modelBuilder.Configurations.Add(new MaterialMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new StatusCollectionMap());
            modelBuilder.Configurations.Add(new Store_LocationsMap());
            modelBuilder.Configurations.Add(new StoreMap());
            modelBuilder.Configurations.Add(new SupplierMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UnitMap());
            modelBuilder.Configurations.Add(new UserRoleMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
