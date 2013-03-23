using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EQ_Output_DetailsMap : EntityTypeConfiguration<EQ_Output_Details>
    {
        public EQ_Output_DetailsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EQ.Output.Details");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OutputID).HasColumnName("OutputID");
            this.Property(t => t.InputID).HasColumnName("InputID");
            this.Property(t => t.EquipmentID).HasColumnName("EquipmentID");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.VNPrice).HasColumnName("VNPrice");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.EQ_Outputs)
                .WithMany(t => t.EQ_Output_Details)
                .HasForeignKey(d => d.OutputID);

        }
    }
}
