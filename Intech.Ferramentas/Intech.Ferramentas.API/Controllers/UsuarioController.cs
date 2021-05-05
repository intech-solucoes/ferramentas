using Intech.Lib.JWT;
using Intech.Lib.Web.API;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Intech.Ferramentas.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public bool Admin => Convert.ToBoolean(User.Claims.GetValue("Admin"));
        public string Cpf => User.Claims.GetValue("Cpf");

        [HttpGet("admin")]
        [Authorize("Bearer")]
        public IActionResult VerificarAdmin()
        {
            try
            {
                if (Admin)
                    return Ok(true);
                else
                    return Ok(false);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("[action]")]
        [AllowAnonymous]
        [Retorno(nameof(JsonWebToken))]
        public IActionResult Login(
            [FromServices] SigningConfigurations signingConfigurations,
            [FromServices] TokenConfigurations tokenConfigurations,
            [FromBody] LoginEntidade user)
        {
            try
            {
                var claims = new List<KeyValuePair<string, string>> {
                    new KeyValuePair<string, string>("Cpf", user.Cpf),
                    new KeyValuePair<string, string>("Admin", true.ToString())
                };

                var token = AuthenticationToken.Generate(signingConfigurations, tokenConfigurations, user.Cpf, claims);

                return Ok(new
                {
                    token.AccessToken,
                    token.Authenticated,
                    token.Created,
                    token.Expiration,
                    Admin = true
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

    public class LoginEntidade
    {
        public string Cpf { get; set; }
        public string Senha { get; set; }
    }
}
