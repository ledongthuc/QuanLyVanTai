using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class Mat_Order_DetailsMap : EntityTypeConfiguration<Mat_Order_Details>
    {
        public Mat_Order_DetailsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Mat.Order.Details");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.MaterialID).HasColumnName("MaterialID");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.USPrice).HasColumnName("USPrice");
            this.Property(t => t.VNPrice).HasColumnName("VNPrice");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.Mat_Orders)
                .WithMany(t => t.Mat_Order_Details)
                .HasForeignKey(d => d.OrderID);
            this.HasOptional(t => t.Material)
                .WithMany(t => t.Mat_Order_Details)
                .HasForeignKey(d => d.MaterialID);

        }
    }
}
