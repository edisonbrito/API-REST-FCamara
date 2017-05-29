using FCamara.Domain.Entities;
using System.Collections.Generic;

namespace FCamara.Domain.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts(int skip, int take);
    }
}
