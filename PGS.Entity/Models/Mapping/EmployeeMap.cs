using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeID);

            // Properties
            this.Property(t => t.FirstName)
                .HasMaxLength(150);

            this.Property(t => t.LastName)
                .HasMaxLength(150);

            this.Property(t => t.NickName)
                .HasMaxLength(150);

            this.Property(t => t.BirthLocation)
                .HasMaxLength(200);

            this.Property(t => t.Phone)
                .HasMaxLength(250);

            this.Property(t => t.Email)
                .HasMaxLength(250);

            this.Property(t => t.Website)
                .HasMaxLength(250);

            this.Property(t => t.IDNo)
                .HasMaxLength(50);

            this.Property(t => t.IDIssuer)
                .HasMaxLength(250);

            this.Property(t => t.PassportNo)
                .HasMaxLength(50);

            this.Property(t => t.PassportIssuer)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Employees");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.NickName).HasColumnName("NickName");
            this.Property(t => t.Birthday).HasColumnName("Birthday");
            this.Property(t => t.BirthLocation).HasColumnName("BirthLocation");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Website).HasColumnName("Website");
            this.Property(t => t.Picture).HasColumnName("Picture");
            this.Property(t => t.IDNo).HasColumnName("IDNo");
            this.Property(t => t.IDIssuedDate).HasColumnName("IDIssuedDate");
            this.Property(t => t.IDIssuer).HasColumnName("IDIssuer");
            this.Property(t => t.PassportNo).HasColumnName("PassportNo");
            this.Property(t => t.PassportIssuedDate).HasColumnName("PassportIssuedDate");
            this.Property(t => t.PassportExpiredDate).HasColumnName("PassportExpiredDate");
            this.Property(t => t.PassportIssuer).HasColumnName("PassportIssuer");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
