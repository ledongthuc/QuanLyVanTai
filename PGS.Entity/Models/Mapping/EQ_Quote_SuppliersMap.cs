using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EQ_Quote_SuppliersMap : EntityTypeConfiguration<EQ_Quote_Suppliers>
    {
        public EQ_Quote_SuppliersMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EQ.Quote.Suppliers");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.QuoteID).HasColumnName("QuoteID");
            this.Property(t => t.SupplierID).HasColumnName("SupplierID");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.EQ_Quotes)
                .WithMany(t => t.EQ_Quote_Suppliers)
                .HasForeignKey(d => d.QuoteID);

        }
    }
}
