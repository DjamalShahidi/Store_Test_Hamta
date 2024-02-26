using AutoMapper;
using MediatR;
using Store.Application.Contracts.Persistence;
using Store.Application.DTOs.Account;
using Store.Application.JWT;
using Store.Application.Mediatr.Feature.Requests.Commands;
using Store.Application.Responses;

namespace Store.Application.Mediatr.Feature.Handlers.Commands
{
    public class LoginHandler : IRequestHandler<Login, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly JWTService _jwtService;

        public LoginHandler(IUnitOfWork unitOfWork, IMapper mapper, JWTService jwtService)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
            this._jwtService = jwtService;
        }

        public async Task<Response> Handle(Login request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.UserRepository.Login(request.Request.UserName, request.Request.Password);

            if (user == null)
            {
                throw new Exception();
            }

            var roles = await _unitOfWork.UserRepository.GetRolesAsync(user);

            var loginResponseDto = new LoginResponseDto()
            {
                Token = _jwtService.CreateToken(user, roles),
                User = _mapper.Map<UserDto>(user),
            };

            return new Response(loginResponseDto);
        }

    }
}
