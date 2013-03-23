using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class Mat_Request_DetailsMap : EntityTypeConfiguration<Mat_Request_Details>
    {
        public Mat_Request_DetailsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Mat.Request.Details");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.MaterialID).HasColumnName("MaterialID");
            this.Property(t => t.RequestedQuantity).HasColumnName("RequestedQuantity");
            this.Property(t => t.ApprovedQuantity).HasColumnName("ApprovedQuantity");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.Mat_Requests)
                .WithMany(t => t.Mat_Request_Details)
                .HasForeignKey(d => d.RequestID);
            this.HasOptional(t => t.Material)
                .WithMany(t => t.Mat_Request_Details)
                .HasForeignKey(d => d.MaterialID);

        }
    }
}
