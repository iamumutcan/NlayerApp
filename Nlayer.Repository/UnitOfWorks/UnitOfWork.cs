using Nlayer.Core.UnitOfWorks;

namespace Nlayer.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
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
