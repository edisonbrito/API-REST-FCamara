using FCamara.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace FCamara.Infra.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Product");
            HasKey(x => x.Id);
            Property(x => x.Title).IsRequired().HasMaxLength(80);
            Property(x => x.Description);
            Property(x => x.Price);
            Property(x => x.Image).IsRequired().HasMaxLength(1024);
        }
    }
}
