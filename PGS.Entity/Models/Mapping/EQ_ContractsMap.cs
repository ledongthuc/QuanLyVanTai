using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EQ_ContractsMap : EntityTypeConfiguration<EQ_Contracts>
    {
        public EQ_ContractsMap()
        {
            // Primary Key
            this.HasKey(t => t.ContractID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(150);

            this.Property(t => t.ContractPrice)
                .HasMaxLength(250);

            this.Property(t => t.PersonInCharge)
                .HasMaxLength(250);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EQ.Contracts");
            this.Property(t => t.ContractID).HasColumnName("ContractID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.SupplierID).HasColumnName("SupplierID");
            this.Property(t => t.StoreID).HasColumnName("StoreID");
            this.Property(t => t.SignedDate).HasColumnName("SignedDate");
            this.Property(t => t.ContractPrice).HasColumnName("ContractPrice");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
            this.Property(t => t.LatestDeliveryDate).HasColumnName("LatestDeliveryDate");
            this.Property(t => t.PersonInCharge).HasColumnName("PersonInCharge");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
