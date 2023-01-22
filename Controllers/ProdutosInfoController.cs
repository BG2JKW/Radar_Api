using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Radar_Api.DTO;
using Radar_Api.Interfaces;


namespace Radar_Api.Controllers;

[Route("info/produtos")]
[ApiController]
public class ProdutosInfoController : ControllerBase
{
    private IServico<ProdutoInfo> _servico;

    public ProdutosInfoController(IServico<ProdutoInfo> servico)
    {
        _servico = servico;
    }

    [HttpGet("")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Index()
    {
        var produtosInfo = await _servico.TodosAsync();
        return StatusCode(200, produtosInfo);
    }
}
