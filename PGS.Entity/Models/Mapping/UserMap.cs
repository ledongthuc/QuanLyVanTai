using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserID);

            // Properties
            this.Property(t => t.UserName)
                .HasMaxLength(150);

            this.Property(t => t.UserPwd)
                .HasMaxLength(150);

            this.Property(t => t.Position)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Users");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.DeptID).HasColumnName("DeptID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.UserPwd).HasColumnName("UserPwd");
            this.Property(t => t.Position).HasColumnName("Position");
            this.Property(t => t.IsLogin).HasColumnName("IsLogin");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");

            // Relationships
            this.HasOptional(t => t.Department)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.DeptID);
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.EmployeeID);

        }
    }
}
