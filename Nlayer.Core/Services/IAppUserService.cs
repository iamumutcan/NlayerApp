using Nlayer.Core.DTOs;
using Nlayer.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Core.Services
{
    public interface IAppUserService:IService<AppUser>
    {
        Task<AppUserDto> UserLoginAsync(string email, string password);


    }
}
