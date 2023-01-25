using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Radar_Api.DTO;
using Radar_Api.Interfaces;


namespace Radar_Api.Controllers;

[Route("info/pedido")]
[ApiController]
public class ProdutosInfoController : ControllerBase
{
    private IServico<PedidoIdPP> _servico;

    public ProdutosInfoController(IServico<PedidoIdPP> servico)
    {
        _servico = servico;
    }

    [HttpGet("")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Details([FromRoute] int id)
    {
        var pedido_Id = await _servico.BuscaId(id);
        if (pedido_Id is null) return StatusCode(404);
        return StatusCode(200, pedido_Id);
    }
}
