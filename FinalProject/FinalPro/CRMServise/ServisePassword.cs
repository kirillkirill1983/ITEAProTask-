
using FinalPro;
using System.Data.Entity.ModelConfiguration;

namespace FinalPro.CRMServise
{
    class ServisePassword: EntityTypeConfiguration<Password>
    {
        public ServisePassword()
        {
            HasKey(p => p.PasswordID);
            
            Property(p => p.Name).
                IsRequired().
                HasMaxLength(100).
                HasColumnName("Name");
        }
    }
}


