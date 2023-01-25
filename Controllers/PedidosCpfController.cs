using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Radar_Api.DTO;
using Radar_Api.Interfaces;
using Radar_Api.Models;

namespace Radar_Api.Controllers;

[Route("cpf/pedidos")]
[ApiController]
public class PedidosCpfController : ControllerBase
{
    private IServico<Pedido> _servico;

    public PedidosCpfController(IServico<Pedido> servico)
    {
        _servico = servico;
    }

    [HttpGet("")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Index()
    {
        var pedidos = await _servico.TodosAsync();
        return StatusCode(200, pedidos);
    }
}
