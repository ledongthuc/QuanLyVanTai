using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class UnitMap : EntityTypeConfiguration<Unit>
    {
        public UnitMap()
        {
            // Primary Key
            this.HasKey(t => t.UnitID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(250);

            this.Property(t => t.UnitGroup)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Units");
            this.Property(t => t.UnitID).HasColumnName("UnitID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.UnitGroup).HasColumnName("UnitGroup");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
