using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PGS.Entity.Models.Mapping
{
    public class EQ_Ouput_InputsMap : EntityTypeConfiguration<EQ_Ouput_Inputs>
    {
        public EQ_Ouput_InputsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EQ.Ouput.Inputs");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OutputID).HasColumnName("OutputID");
            this.Property(t => t.InputID).HasColumnName("InputID");
            this.Property(t => t.Updator).HasColumnName("Updator");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        }
    }
}
