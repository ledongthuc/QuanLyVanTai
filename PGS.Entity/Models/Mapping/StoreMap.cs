using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class StoreMap : EntityTypeConfiguration<Store>
    {
        public StoreMap()
        {
            // Primary Key
            this.HasKey(t => t.StoreID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(250);

            this.Property(t => t.Type)
                .HasMaxLength(50);

            this.Property(t => t.PersonInCharge)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Stores");
            this.Property(t => t.StoreID).HasColumnName("StoreID");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.PersonInCharge).HasColumnName("PersonInCharge");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
