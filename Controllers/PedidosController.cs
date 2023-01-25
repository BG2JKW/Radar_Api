using Microsoft.AspNetCore.Mvc;
using Radar_Api.Models;
using Radar_Api.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Radar_Api.DTO;

namespace api.Controllers;

[Route("pedidos")]
[ApiController]
public class PedidosController : ControllerBase
{
    private IServico<Pedido> _servico;

    public PedidosController(IServico<Pedido> servico)
    {
        _servico = servico;
    }

    [HttpGet("")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Index()
    {
        var pedidos = await _servico.TodosAsync();
        if(pedidos == null)
        {
            return NotFound();
        }
        return Ok(pedidos);
    }

    [HttpGet("{id}")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Details([FromRoute] int id)
    {
        var pedido = await _servico.BuscaId(id);

        return StatusCode(200, pedido);
    }

    [HttpPost("")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Create([FromBody] Pedido pedido)
    {
        await _servico.IncluirAsync(pedido);
        return StatusCode(201, pedido);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "adm")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Pedido pedido)
    {
        if (id != pedido.Id)
        {
            return StatusCode(400, new
            {
                Mensagem = "O Id do pedido precisa bater com o id da URL"
            });
        }

        var pedidoDb = await _servico.AtualizarAsync(pedido);

        return StatusCode(200, pedidoDb);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "adm")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var pedidoDb = (await _servico.TodosAsync()).Find(c => c.Id == id);
        if (pedidoDb is null)
        {
            return StatusCode(404, new
            {
                Mensagem = "O pedido informado não existe"
            });
        }

        await _servico.ApagarAsync(pedidoDb);

        return StatusCode(204);
    }
    
}