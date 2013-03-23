using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class MaterialMap : EntityTypeConfiguration<Material>
    {
        public MaterialMap()
        {
            // Primary Key
            this.HasKey(t => t.MaterialID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(255);

            this.Property(t => t.Name)
                .HasMaxLength(255);

            this.Property(t => t.IMEI)
                .HasMaxLength(50);

            this.Property(t => t.Origin)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Materials");
            this.Property(t => t.MaterialID).HasColumnName("MaterialID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.MatCatID).HasColumnName("MatCatID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Picture).HasColumnName("Picture");
            this.Property(t => t.UnitID).HasColumnName("UnitID");
            this.Property(t => t.USPrice).HasColumnName("USPrice");
            this.Property(t => t.VNPrice).HasColumnName("VNPrice");
            this.Property(t => t.LastBoughtDate).HasColumnName("LastBoughtDate");
            this.Property(t => t.IMEI).HasColumnName("IMEI");
            this.Property(t => t.Origin).HasColumnName("Origin");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.Mat_Categories)
                .WithMany(t => t.Materials)
                .HasForeignKey(d => d.MatCatID);
            this.HasOptional(t => t.Unit)
                .WithMany(t => t.Materials)
                .HasForeignKey(d => d.UnitID);

        }
    }
}
