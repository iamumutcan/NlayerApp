﻿using Nlayer.Core.DTOs;
using Nlayer.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Core.Services
{
    public interface IUserService:IService<User>
    {
        Task<UserDto> UserLoginAsync(string email, string password);


    }
}