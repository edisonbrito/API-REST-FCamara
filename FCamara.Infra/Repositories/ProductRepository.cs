using FCamara.Domain.Entities;
using FCamara.Domain.Repositories;
using FCamara.Infra.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace FCamara.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly FCamaraDataContext _context;

        public ProductRepository(FCamaraDataContext context)
        {
            _context = context;
        }
     
        public List<Product> GetAllProducts(int skip, int take)
        {
            return _context.Products.OrderBy(x => x.Title).Skip(skip).Take(take).ToList();
        }
    }
}
