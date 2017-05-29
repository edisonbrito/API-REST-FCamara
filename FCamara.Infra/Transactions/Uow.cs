using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FCamara.Infra.Contexts;

namespace FCamara.Infra.Transactions
{
    public class Uow : IUow
    {
        private readonly FCamaraDataContext _context;

        public Uow(FCamaraDataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback() {}
    }
}
