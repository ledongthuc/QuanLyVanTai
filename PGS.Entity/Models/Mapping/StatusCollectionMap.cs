using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class StatusCollectionMap : EntityTypeConfiguration<StatusCollection>
    {
        public StatusCollectionMap()
        {
            // Primary Key
            this.HasKey(t => t.StatusID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Abbreviation)
                .HasMaxLength(15);

            this.Property(t => t.StatusGroup)
                .HasMaxLength(50);

            this.Property(t => t.Notes)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("StatusCollections");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Abbreviation).HasColumnName("Abbreviation");
            this.Property(t => t.StatusGroup).HasColumnName("StatusGroup");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
