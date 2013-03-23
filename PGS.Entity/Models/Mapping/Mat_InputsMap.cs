using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class Mat_InputsMap : EntityTypeConfiguration<Mat_Inputs>
    {
        public Mat_InputsMap()
        {
            // Primary Key
            this.HasKey(t => t.InputID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(150);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Mat.Inputs");
            this.Property(t => t.InputID).HasColumnName("InputID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.SupplierID).HasColumnName("SupplierID");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.Mat_Orders)
                .WithMany(t => t.Mat_Inputs)
                .HasForeignKey(d => d.OrderID);

        }
    }
}
