using FCamara.Domain.Entities;

namespace FCamara.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Customer Get(int id);
        Customer GetByUsername(string username);
    }
}
