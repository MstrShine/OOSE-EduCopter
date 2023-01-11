using EduCopter.Domain.Users;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EduCopter.API.JWT
{
    public class TokenService : ITokenService
    {
        private const double EXPIRY_DURATION_MINUTES = 30;

        public string BuildToken(string key, string issuer, UserInfo user)
        {
            var claims = new List<Claim>() {
                new Claim(ClaimTypes.Name, user.Username),
            };


            if (user is Student)
            {
                claims.Add(new Claim(ClaimTypes.Actor, nameof(Student)));
            }
            else if (user is Teacher)
            {
                claims.Add(new Claim(ClaimTypes.Actor, nameof(Teacher)));
            }
            else if (user is Administrator)
            {
                claims.Add(new Claim(ClaimTypes.Actor, nameof(Administrator)));
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new JwtSecurityToken(issuer, issuer, claims,
                expires: DateTime.Now.AddMinutes(EXPIRY_DURATION_MINUTES), signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }

        public bool ValidateToken(string key, string issuer, string audience, string token, out string user)
        {
            var mySecret = Encoding.UTF8.GetBytes(key);
            var mySecurityKey = new SymmetricSecurityKey(mySecret);
            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                tokenHandler.ValidateToken(token,
                new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = issuer,
                    ValidAudience = issuer,
                    IssuerSigningKey = mySecurityKey,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var name = jwtToken.Claims.First(x => x.Type == ClaimTypes.Name).Value;
                user = name;
            }
            catch
            {
                user = null;
                return false;
            }

            return true;
        }
    }
}
