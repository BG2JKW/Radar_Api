using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Radar_Api.Autenticacao;
using Radar_Api.DTO;
using Radar_Api.Interfaces;
using Radar_Api.Models;
using Radar_Api.ModelViews;
using Radar_Api.Service;

namespace Radar_Api.Controllers;

public class LoginController : ControllerBase
{
    private IServicoCadastro<Cadastro> _servico;
    public LoginController(IServicoCadastro<Cadastro> servico)
    {
        _servico = servico;
    }
    
    [HttpPost("/login")]
    [AllowAnonymous]
    public async Task<IActionResult> Login([FromBody] CadastroDTO cadastroDTO)
    {
        if(string.IsNullOrEmpty(cadastroDTO.Email) || string.IsNullOrEmpty(cadastroDTO.Senha))
            return StatusCode(400, new {
                Mensagem = "Preencha o email e a senha"
            });

        var administrador = await _servico.Login(cadastroDTO.Email, cadastroDTO.Senha);
        if(administrador is null)
            return StatusCode(404, new {
                Mensagem = "Usuario ou senha não encontrado em nossa base de dados"
            });

        var admLogado = BuilderService<Logado>.Builder(administrador);
        admLogado.Token = UserToken.Builder(admLogado);

        return StatusCode(200, admLogado);
    }
}