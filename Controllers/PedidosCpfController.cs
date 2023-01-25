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
    private IServico<PedidoCpf> _servico;


    public PedidosCpfController(IServico<PedidoCpf> servico)
    {
        _servico = servico;
    }

    [HttpGet("")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Index()
    {
        var pedidos = await _servico.TodosAsync();
        if (pedidos == null)
        {
            return NotFound();
        }
        return Ok(pedidos);
    }
}
