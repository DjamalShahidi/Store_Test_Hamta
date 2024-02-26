using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Store.Application.Contracts.Persistence;
using Store.Application.DTOs.Account;
using Store.Domain;
using Store.Persistence.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Store.Persistence.Repositories
{
    public class UserRepository : GenericRepository<ApplicationUser>, IUserRepository
    {
        private readonly StoreDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserRepository(StoreDbContext context,
                              UserManager<ApplicationUser> userManager, 
                              RoleManager<IdentityRole> roleManager) : base(context)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

    

        public async Task<bool> IsUniqueUser(string username)
        {
            var user =await _context.ApplicationUsers.FirstOrDefaultAsync(x => x.UserName == username);
            if (user == null)
            {
                return true;
            }
            return false;
        }

        public async Task<ApplicationUser> Login(string username,string password)
        {
            var user = _context.ApplicationUsers
                .FirstOrDefault(u => u.UserName.ToLower() == username.ToLower());

            bool isValid = await _userManager.CheckPasswordAsync(user, password);

            if (user == null || isValid == false)
            {
                return null;
            }

            return user;
        }

        public async Task<IList<string>> GetRolesAsync(ApplicationUser user)
        {
            return await _userManager.GetRolesAsync(user);
        }


        public async Task<IdentityResult> Register(ApplicationUser user,string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task<bool> RoleExistsAsync(string roleName)
        {
            return await _roleManager.RoleExistsAsync(roleName);
        }

        public async Task CreateRolesAsync(List<IdentityRole> roles)
        {
            foreach (var role in roles)
            {
                await _roleManager.CreateAsync(role);
            }
        }
        public async Task AddToRoleAsync(ApplicationUser user,string role )
        {
            await _userManager.AddToRoleAsync(user, role);
        }

        public async Task<ApplicationUser> GetByUserName(string username)
        {
            return await _context.ApplicationUsers.FirstOrDefaultAsync(u => u.UserName == username);

        }



        //public async Task<UserDTO> Register(RegisterationRequestDTO registerationRequestDTO)
        //{
        //    ApplicationUser user = new()
        //    {
        //        UserName = registerationRequestDTO.UserName,
        //        Email = registerationRequestDTO.UserName,
        //        NormalizedEmail = registerationRequestDTO.UserName.ToUpper(),
        //        Name = registerationRequestDTO.Name
        //    };

        //    try
        //    {
        //        var result = await _userManager.CreateAsync(user, registerationRequestDTO.Password);
        //        if (result.Succeeded)
        //        {
        //            if (!_roleManager.RoleExistsAsync("admin").GetAwaiter().GetResult())
        //            {
        //                await _roleManager.CreateAsync(new IdentityRole("admin"));
        //                await _roleManager.CreateAsync(new IdentityRole("user"));
        //            }
        //            await _userManager.AddToRoleAsync(user, "admin");
        //            var userToReturn = _context.ApplicationUsers
        //                .FirstOrDefault(u => u.UserName == registerationRequestDTO.UserName);
        //            return _mapper.Map<UserDTO>(userToReturn);

        //        }
        //    }
        //    catch (Exception e)
        //    {

        //    }

        //    return new UserDTO();
        //}




    }
}
