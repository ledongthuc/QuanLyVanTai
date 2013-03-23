using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class SupplierMap : EntityTypeConfiguration<Supplier>
    {
        public SupplierMap()
        {
            // Primary Key
            this.HasKey(t => t.SupplierID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(100);

            this.Property(t => t.Name)
                .HasMaxLength(255);

            this.Property(t => t.ShortName)
                .HasMaxLength(150);

            this.Property(t => t.Phone)
                .HasMaxLength(250);

            this.Property(t => t.Fax)
                .HasMaxLength(250);

            this.Property(t => t.Email)
                .HasMaxLength(250);

            this.Property(t => t.Website)
                .HasMaxLength(250);

            this.Property(t => t.AccountNo)
                .HasMaxLength(150);

            this.Property(t => t.TaxNo)
                .HasMaxLength(100);

            this.Property(t => t.ContactPerson)
                .HasMaxLength(250);

            this.Property(t => t.ContactMobile)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Suppliers");
            this.Property(t => t.SupplierID).HasColumnName("SupplierID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ShortName).HasColumnName("ShortName");
            this.Property(t => t.CoTypeID).HasColumnName("CoTypeID");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Website).HasColumnName("Website");
            this.Property(t => t.AccountNo).HasColumnName("AccountNo");
            this.Property(t => t.TaxNo).HasColumnName("TaxNo");
            this.Property(t => t.ContactPerson).HasColumnName("ContactPerson");
            this.Property(t => t.ContactMobile).HasColumnName("ContactMobile");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.CoType)
                .WithMany(t => t.Suppliers)
                .HasForeignKey(d => d.CoTypeID);

        }
    }
}
