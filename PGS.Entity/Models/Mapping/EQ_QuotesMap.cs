using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EQ_QuotesMap : EntityTypeConfiguration<EQ_Quotes>
    {
        public EQ_QuotesMap()
        {
            // Primary Key
            this.HasKey(t => t.QuoteID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(150);

            this.Property(t => t.Follower)
                .HasMaxLength(250);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EQ.Quotes");
            this.Property(t => t.QuoteID).HasColumnName("QuoteID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.QuoteDate).HasColumnName("QuoteDate");
            this.Property(t => t.Follower).HasColumnName("Follower");
            this.Property(t => t.AcceptedDate).HasColumnName("AcceptedDate");
            this.Property(t => t.DeadLine).HasColumnName("DeadLine");
            this.Property(t => t.OtherIssues).HasColumnName("OtherIssues");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
