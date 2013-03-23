using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EQ_Contract_DetailsMap : EntityTypeConfiguration<EQ_Contract_Details>
    {
        public EQ_Contract_DetailsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EQ.Contract.Details");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ContractID).HasColumnName("ContractID");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.EquipmentID).HasColumnName("EquipmentID");
            this.Property(t => t.RequestQuantity).HasColumnName("RequestQuantity");
            this.Property(t => t.ContractQuantity).HasColumnName("ContractQuantity");
            this.Property(t => t.VNPrice).HasColumnName("VNPrice");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.EQ_Contracts)
                .WithMany(t => t.EQ_Contract_Details)
                .HasForeignKey(d => d.ContractID);
            this.HasOptional(t => t.Equipment)
                .WithMany(t => t.EQ_Contract_Details)
                .HasForeignKey(d => d.EquipmentID);

        }
    }
}
