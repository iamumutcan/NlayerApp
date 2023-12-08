using Nlayer.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Repository.Repositories
{
    public class AppUserRepository : GenericRepository<AppUser>
    {
        public AppUserRepository(AppDbContext context) : base(context)
        {
        }
    }
}
