using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EQ_OrdersMap : EntityTypeConfiguration<EQ_Orders>
    {
        public EQ_OrdersMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(150);

            this.Property(t => t.Priority)
                .HasMaxLength(50);

            this.Property(t => t.Receiver)
                .HasMaxLength(250);

            this.Property(t => t.DeliveryLocation)
                .HasMaxLength(250);

            this.Property(t => t.PersonInCharge)
                .HasMaxLength(250);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EQ.Orders");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.SupplierID).HasColumnName("SupplierID");
            this.Property(t => t.StoreID).HasColumnName("StoreID");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.Receiver).HasColumnName("Receiver");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
            this.Property(t => t.DeliveryLocation).HasColumnName("DeliveryLocation");
            this.Property(t => t.Pricing).HasColumnName("Pricing");
            this.Property(t => t.PaymentTerm).HasColumnName("PaymentTerm");
            this.Property(t => t.Quality).HasColumnName("Quality");
            this.Property(t => t.Warranty).HasColumnName("Warranty");
            this.Property(t => t.RegardingTo).HasColumnName("RegardingTo");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.PersonInCharge).HasColumnName("PersonInCharge");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
