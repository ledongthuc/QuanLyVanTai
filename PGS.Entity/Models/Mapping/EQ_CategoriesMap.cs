using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EQ_CategoriesMap : EntityTypeConfiguration<EQ_Categories>
    {
        public EQ_CategoriesMap()
        {
            // Primary Key
            this.HasKey(t => t.EQCatID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(100);

            this.Property(t => t.Name)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("EQ.Categories");
            this.Property(t => t.EQCatID).HasColumnName("EQCatID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
