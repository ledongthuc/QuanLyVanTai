using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class Mat_OrdersMap : EntityTypeConfiguration<Mat_Orders>
    {
        public Mat_OrdersMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(250);

            this.Property(t => t.ContactPerson)
                .HasMaxLength(250);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            this.Property(t => t.Priority)
                .HasMaxLength(100);

            this.Property(t => t.DeliveryLocation)
                .HasMaxLength(250);

            this.Property(t => t.Receiver)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Mat.Orders");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.ContactPerson).HasColumnName("ContactPerson");
            this.Property(t => t.SupplierID).HasColumnName("SupplierID");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.OrderReason).HasColumnName("OrderReason");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
            this.Property(t => t.DeliveryLocation).HasColumnName("DeliveryLocation");
            this.Property(t => t.Receiver).HasColumnName("Receiver");
            this.Property(t => t.OtherInfo).HasColumnName("OtherInfo");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.Mat_Requests)
                .WithMany(t => t.Mat_Orders)
                .HasForeignKey(d => d.RequestID);

        }
    }
}
