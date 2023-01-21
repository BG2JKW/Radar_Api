using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Radar_Api.ModelViews;

namespace Radar_Api.Autenticacao;

public class UserToken
{
    public readonly static string Key = "BG2JKW_radar_Api"; 
    public static string Builder(Logado logado)
    {
        var key = Encoding.ASCII.GetBytes(UserToken.Key);
        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenDescriptor = new SecurityTokenDescriptor()
        {
            Subject = new ClaimsIdentity(new Claim[]{
                new Claim(ClaimTypes.Name, logado.Nome),
                new Claim(ClaimTypes.Role, logado.Permissao),
            }),
            Expires = DateTime.UtcNow.AddHours(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

}