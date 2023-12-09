using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nlayer.Core.DTOs;
using Nlayer.Core.Model;
using Nlayer.Core.Services;

namespace Nlayer.API.Controllers
{

    public class AppUserController : CustomBaseController
    {
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;

        public AppUserController(IAppUserService appUserService, IMapper mapper)
        {
            _appUserService = appUserService;
            _mapper = mapper;
        }


        [HttpPost]
        public async Task<IActionResult> Save(AppUserDto objDto)
        {
            var obj = await _appUserService.AddAsync(_mapper.Map<AppUser>(objDto));
            var objsDto = _mapper.Map<AppUserDto>(obj);
            return CreateActionResult(CustomResponseDto<AppUserDto>.Success(201, objsDto));
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(AppUserLoginDto objDto)
        {
            var appUser = _mapper.Map<AppUser>(objDto);

            var addedUser = await _appUserService.UserLoginAsync(appUser.Email, appUser.Password);
            var addedUserDto = _mapper.Map<AppUserDto>(addedUser);
            var addedUser2 = await _appUserService.UserLoginAsync(appUser.Email, appUser.Password);
            return CreateActionResult(CustomResponseDto<AppUserDto>.Success(201, addedUserDto));
        }


    }
}
