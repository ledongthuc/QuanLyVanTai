using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class Mat_Repair_DetailsMap : EntityTypeConfiguration<Mat_Repair_Details>
    {
        public Mat_Repair_DetailsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Mat.Repair.Details");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RepairID).HasColumnName("RepairID");
            this.Property(t => t.MaterialID).HasColumnName("MaterialID");
            this.Property(t => t.SupplierID).HasColumnName("SupplierID");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.RepairCost).HasColumnName("RepairCost");
            this.Property(t => t.ReturnDate).HasColumnName("ReturnDate");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.Mat_Repairs)
                .WithMany(t => t.Mat_Repair_Details)
                .HasForeignKey(d => d.RepairID);
            this.HasOptional(t => t.Material)
                .WithMany(t => t.Mat_Repair_Details)
                .HasForeignKey(d => d.MaterialID);

        }
    }
}
