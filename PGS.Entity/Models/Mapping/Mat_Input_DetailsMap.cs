using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class Mat_Input_DetailsMap : EntityTypeConfiguration<Mat_Input_Details>
    {
        public Mat_Input_DetailsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.WarrantyTime)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Mat.Input.Details");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InputID).HasColumnName("InputID");
            this.Property(t => t.MaterialID).HasColumnName("MaterialID");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.USPrice).HasColumnName("USPrice");
            this.Property(t => t.VNPrice).HasColumnName("VNPrice");
            this.Property(t => t.WarrantyTime).HasColumnName("WarrantyTime");
            this.Property(t => t.ReceiveDeptID).HasColumnName("ReceiveDeptID");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.Mat_Inputs)
                .WithMany(t => t.Mat_Input_Details)
                .HasForeignKey(d => d.InputID);
            this.HasOptional(t => t.Material)
                .WithMany(t => t.Mat_Input_Details)
                .HasForeignKey(d => d.MaterialID);

        }
    }
}
