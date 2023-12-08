using AutoMapper;
using Nlayer.Core.Repositories;
using Nlayer.Core.Services;
using Nlayer.Core.UnitOfWorks;


namespace Nlayer.Service.Services
{
    public class AppUser : Service<AppUser>
    {
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;
        public AppUser(IGenericRepository<AppUser> repository, IUnitOfWork unitOfWork, IAppUserService appUserService, IMapper mapper) : base(repository, unitOfWork)
        {
            _appUserService = appUserService;
            _mapper = mapper;
        }
    }
}
