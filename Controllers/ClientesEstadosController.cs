using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Radar_Api.DTO;
using Radar_Api.Interfaces;

namespace Radar_Api.Controllers;

[Route("estados/clientes")]
[ApiController]
public class ClientesEstadosController : ControllerBase
{
    private IServico<ClienteEstado> _servico;

    public ClientesEstadosController(IServico<ClienteEstado> servico)
    {
        _servico = servico;
    }

    [HttpGet("")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Index()
    {
        var estadosClientes = await _servico.TodosAsync();
        return StatusCode(200, estadosClientes);
    }
}