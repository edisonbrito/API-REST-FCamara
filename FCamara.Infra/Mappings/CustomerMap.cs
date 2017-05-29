using FCamara.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace FCamara.Infra.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customer");
            HasKey(x => x.Id);
            Property(x => x.Name).IsRequired();
            Property(x => x.Active).IsRequired();
            Property(x => x.Email.Address).HasColumnName("Email").IsRequired().HasMaxLength(160);
         
            HasRequired(x => x.User);
        }
    }
}
