using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EquipmentMap : EntityTypeConfiguration<Equipment>
    {
        public EquipmentMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(250);

            this.Property(t => t.Name)
                .HasMaxLength(255);

            this.Property(t => t.PartNumber)
                .HasMaxLength(250);

            this.Property(t => t.ReferCode)
                .HasMaxLength(250);

            this.Property(t => t.Origin)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Equipments");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.PartNumber).HasColumnName("PartNumber");
            this.Property(t => t.ReferCode).HasColumnName("ReferCode");
            this.Property(t => t.StoreID).HasColumnName("StoreID");
            this.Property(t => t.UnitID).HasColumnName("UnitID");
            this.Property(t => t.EQCatID).HasColumnName("EQCatID");
            this.Property(t => t.Origin).HasColumnName("Origin");
            this.Property(t => t.IsCritical).HasColumnName("IsCritical");
            this.Property(t => t.IsReusable).HasColumnName("IsReusable");
            this.Property(t => t.Picture).HasColumnName("Picture");
            this.Property(t => t.EquipmentLevel).HasColumnName("EquipmentLevel");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.EQ_Categories)
                .WithMany(t => t.Equipments)
                .HasForeignKey(d => d.EQCatID);
            this.HasOptional(t => t.Unit)
                .WithMany(t => t.Equipments)
                .HasForeignKey(d => d.UnitID);

        }
    }
}
