using Employee_Management_System.Employees_Model;
using Employee_Management_System.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
using Volo.Abp.Security.Claims;
using Volo.Abp.Users;

namespace Employee_Management_System.EmployeeServices
{
    public class TokenService:ITokenService,IScopedDependency
    {
        protected IdentityUserManager UserManager;
        private readonly ICurrentUser _currentUser;
        private readonly IConfiguration _config;
        private readonly UserManager<Volo.Abp.Identity.IdentityUser> _userManager;
       
        public TokenService(UserManager<Volo.Abp.Identity.IdentityUser> userManager,
         
            IRepository<Volo.Abp.Identity.IdentityUser, Guid> userRepositoy,
            IConfiguration config,
            ICurrentUser currentUser) {
            _currentUser = currentUser;
            _userManager = userManager;
            _currentUser = currentUser;
            _config = config;
         }

        public async Task<LoginPage> Login(Login model)
        {
            var user = await _userManager.FindByEmailAsync(model.email);
            var isValid = await _userManager.CheckPasswordAsync(user, model.password);
            if (user != null && isValid)
            {
                var roles = await _userManager.GetRolesAsync(user);
                var claims = CreateClaims(user, roles);
                var token = await GenerateJwtTokenAsync(user, claims);
                return new LoginPage { Data = user, Message = "You have login successfully", token = token, StatusCode = 200 };
            }
            return new LoginPage { Message = "Invalid Credentials", StatusCode = 401 };
        }

        /*Generate Token*/
        private async Task<string> GenerateJwtTokenAsync(IUser user, IEnumerable<Claim> claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["jwt:key"]));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(2), 
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private static IEnumerable<Claim> CreateClaims(IUser user, IEnumerable<string> roles)
        {
            /*Creating cliams*/
            var claims = new List<Claim>
            {
                new Claim(AbpClaimTypes.UserId, user.Id.ToString()),
                new Claim(AbpClaimTypes.Email, user.Email),
                new Claim(AbpClaimTypes.UserName, user.UserName),
                new Claim(AbpClaimTypes.EmailVerified, user.EmailConfirmed.ToString().ToLower()),
            };

            if (!string.IsNullOrWhiteSpace(user.PhoneNumber))
            {
                claims.Add(new Claim(AbpClaimTypes.PhoneNumber, user.PhoneNumber));
            }

            foreach (var role in roles)
            {
                claims.Add(new Claim(AbpClaimTypes.Role, role));
            }

            return claims;
        }
    }
  
}
