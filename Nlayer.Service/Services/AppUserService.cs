using AutoMapper;
using Nlayer.Core.DTOs;
using Nlayer.Core.Model;
using Nlayer.Core.Repositories;
using Nlayer.Core.Services;
using Nlayer.Core.UnitOfWorks;

namespace Nlayer.Service.Services
{
    public class AppUserService : Service<AppUser>,IAppUserService
    {
        private readonly IAppUserRepository _appUserRepository;
        private readonly IMapper _mapper;

        public AppUserService(IGenericRepository<AppUser> repository, IUnitOfWork unitOfWork, IAppUserRepository appUserRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _appUserRepository = appUserRepository;
            _mapper = mapper;
        }

        public async Task<AppUserDto> UserLoginAsync(string email, string password)
        {
           var user = _appUserRepository.Where(u => u.Email == email && u.Password == password).FirstOrDefault();
            var userDto = _mapper.Map<AppUserDto>(user);
            return userDto;
        }
    }
}
