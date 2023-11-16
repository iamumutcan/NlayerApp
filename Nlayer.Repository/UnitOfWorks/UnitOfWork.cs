using Nlayer.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Repository.UnitOfWorks
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context) { _context = context; }

        public void Comit()
        {
            _context.SaveChanges();
        }

        public async Task ComitAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
