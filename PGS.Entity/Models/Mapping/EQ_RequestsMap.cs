using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EQ_RequestsMap : EntityTypeConfiguration<EQ_Requests>
    {
        public EQ_RequestsMap()
        {
            // Primary Key
            this.HasKey(t => t.RequestID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(150);

            this.Property(t => t.ProcedureCode)
                .HasMaxLength(150);

            this.Property(t => t.Priority)
                .HasMaxLength(100);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EQ.Requests");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.StoreID).HasColumnName("StoreID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.RequestDate).HasColumnName("RequestDate");
            this.Property(t => t.ProcedureCode).HasColumnName("ProcedureCode");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.EQCatID).HasColumnName("EQCatID");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
