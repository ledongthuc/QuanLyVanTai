using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class Mat_RequestsMap : EntityTypeConfiguration<Mat_Requests>
    {
        public Mat_RequestsMap()
        {
            // Primary Key
            this.HasKey(t => t.RequestID);

            // Properties
            this.Property(t => t.ProdecureCode)
                .HasMaxLength(150);

            this.Property(t => t.Code)
                .HasMaxLength(150);

            this.Property(t => t.RequestForWhen)
                .HasMaxLength(250);

            this.Property(t => t.Priority)
                .HasMaxLength(100);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Mat.Requests");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.ProdecureCode).HasColumnName("ProdecureCode");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.SendDeptID).HasColumnName("SendDeptID");
            this.Property(t => t.ReceiveDeptID).HasColumnName("ReceiveDeptID");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.RequestForWhen).HasColumnName("RequestForWhen");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
