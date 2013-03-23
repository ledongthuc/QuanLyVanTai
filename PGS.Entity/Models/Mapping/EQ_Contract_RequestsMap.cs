using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EQ_Contract_RequestsMap : EntityTypeConfiguration<EQ_Contract_Requests>
    {
        public EQ_Contract_RequestsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EQ.Contract.Requests");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ContractID).HasColumnName("ContractID");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
