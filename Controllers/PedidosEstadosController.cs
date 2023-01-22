using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Radar_Api.DTO;
using Radar_Api.Interfaces;
using System.Data;


namespace Radar_Api.Controllers;

[Route("estados/pedidos")]
[ApiController]
public class PedidosEstadosController : ControllerBase
{
    private IServico<PedidoEstado> _servico;

    public PedidosEstadosController(IServico<PedidoEstado> servico)
    {
        _servico = servico;
    }

    [HttpGet("")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Index()
    {
        var estadosPedidos = await _servico.TodosAsync();
        return StatusCode(200, estadosPedidos);
    }
}
