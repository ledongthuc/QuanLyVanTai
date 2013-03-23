using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class CoTypeMap : EntityTypeConfiguration<CoType>
    {
        public CoTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.CoTypeID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("CoTypes");
            this.Property(t => t.CoTypeID).HasColumnName("CoTypeID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
