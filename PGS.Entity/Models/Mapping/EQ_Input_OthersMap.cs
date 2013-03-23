using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EQ_Input_OthersMap : EntityTypeConfiguration<EQ_Input_Others>
    {
        public EQ_Input_OthersMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EQ.Input.Others");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InputID).HasColumnName("InputID");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.ContractID).HasColumnName("ContractID");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
