using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;

namespace LuckyStone.WebApi.Controllers;

[Route("/token")]
public class TokenController : Controller
{
    [HttpGet("create")]
    public async Task<IActionResult> Create()
    {
        var tokenHandler = new JsonWebTokenHandler();
        var key = "AErfserDefd64s!*sds4qWxsaredghrs46&%3s135";
        var binaryKey = UTF8Encoding.UTF8.GetBytes(key);
        var token = tokenHandler.CreateToken(new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim("user.name", "aaa")
            }),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(binaryKey), SecurityAlgorithms.HmacSha256),
            Issuer = "http://localhost:5038/",
            Audience = "http://localhost:5038/",
            Expires = DateTime.Now.AddMinutes(1)
        });
        
        return Ok(token);
    }
}