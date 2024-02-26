using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Store.Application.Contracts.Persistence;
using Store.Application.DTOs.Account;
using Store.Application.JWT;
using Store.Application.Mediatr.Feature.Requests.Commands;
using Store.Application.Responses;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Mediatr.Feature.Handlers.Commands
{

    public class RegisterHandler : IRequestHandler<Register, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RegisterHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<Response> Handle(Register request, CancellationToken cancellationToken)
        {
            var ifUserNameUnique =await _unitOfWork.UserRepository.IsUniqueUser(request.Request.UserName);

            if (!ifUserNameUnique)
            {
                throw new Exception();
            }

            var user = new ApplicationUser()
            {
                UserName = request.Request.UserName,
                Email = request.Request.UserName,
                NormalizedEmail = request.Request.UserName.ToUpper(),
                Name = request.Request.Name
            };
            using (var transaction = await _unitOfWork.BeginTransactionAsync(cancellationToken))
            {
                try
                {
                    var result = await _unitOfWork.UserRepository.Register(user, request.Request.Password);

                    if (result.Succeeded)
                    {
                        if (!await _unitOfWork.UserRepository.RoleExistsAsync("admin"))
                        {
                            await _unitOfWork.UserRepository.CreateRolesAsync([
                                                                                  new IdentityRole("admin"),
                                                                                  new IdentityRole("user")
                                                                              ]);
                        }
                        if (await _unitOfWork.UserRepository.RoleExistsAsync(request.Request.Role))
                        {

                            await _unitOfWork.UserRepository.AddToRoleAsync(user, request.Request.Role);

                            await _unitOfWork.Save(cancellationToken);
                            await transaction.CommitAsync(cancellationToken);

                        }
                        else
                        {
                            await transaction.RollbackAsync(cancellationToken);
                            return new Response(new List<string>() { "Role not exsit" });

                        }

                    }
                    else
                    {
                        await transaction.RollbackAsync(cancellationToken);

                        return new Response(result.Errors.Select(a => a.Description).ToList());

                    }
                }
                catch (Exception ex)
                {

                    await transaction.RollbackAsync(cancellationToken);
                    return new Response($"Fatal error {ex.Message}");
                }

                
            }

            var userToReturn = await _unitOfWork.UserRepository.GetByUserName(request.Request.UserName);

            return new Response(_mapper.Map<UserDto>(userToReturn));

        }

    }
}
