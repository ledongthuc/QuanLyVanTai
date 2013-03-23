using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class Mat_RepairsMap : EntityTypeConfiguration<Mat_Repairs>
    {
        public Mat_RepairsMap()
        {
            // Primary Key
            this.HasKey(t => t.RepairID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(150);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Mat.Repairs");
            this.Property(t => t.RepairID).HasColumnName("RepairID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
