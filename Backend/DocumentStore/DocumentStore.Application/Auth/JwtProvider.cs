using DocumentStore.Domain.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Options;
using DocumentStore.Domain.Models;
using System.Security.Claims;
using System.Text;

namespace DocumentStore.Application.Auth
{
    public class JwtProvider : IJwtProvider
    {
        private readonly JwtOptions _jwtOptions;

        public JwtProvider(IOptions<JwtOptions> jwtOptions)
        {
            _jwtOptions = jwtOptions.Value;
        }

        public string GenerateToken(UserModel user)
        {
            Claim[] claims = [
                new("userId", user.Id.ToString()),
                new("email", user.Email)];

            SigningCredentials signingCredentials = new(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.SecretKey)),
                SecurityAlgorithms.HmacSha256);

            JwtSecurityToken token = new(
                claims: claims,
                signingCredentials: signingCredentials,
                expires: DateTime.UtcNow.AddHours(12));

            string value = new JwtSecurityTokenHandler().WriteToken(token);

            return value;
        }
    }
}
