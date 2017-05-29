using FCamara.Domain.Entities;
using FCamara.Domain.Repositories;
using FCamara.Infra.Contexts;
using System.Data.Entity;
using System.Linq;

namespace FCamara.Infra.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly FCamaraDataContext _context;

        public CustomerRepository(FCamaraDataContext context)
        {
            _context = context;
        }

        public Customer Get(int id)
        {
            return _context
                .Customers
                .Include(x => x.User)
                .FirstOrDefault(x => x.Id == id);
        }

        public Customer GetByUsername(string username)
        {
            return _context
                .Customers
                .Include(x => x.User)
                .AsNoTracking()
                .FirstOrDefault(x => x.User.Username == username);
        }
    }
}
