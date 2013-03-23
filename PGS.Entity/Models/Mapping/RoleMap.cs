using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            // Primary Key
            this.HasKey(t => t.RoleID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(100);

            this.Property(t => t.Name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Roles");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
