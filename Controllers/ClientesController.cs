using Microsoft.AspNetCore.Mvc;
using Radar_Api.Models;
using Radar_Api.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace api.Controllers;

[Route("clientes")]
[ApiController]
public class ClientesController : ControllerBase
{
    private IServico<Cliente> _servico;
    public ClientesController(IServico<Cliente> servico)
    {
        _servico = servico;
    }

    [HttpGet("")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Index()
    {
        var clientes = await _servico.TodosAsync();
        return StatusCode(200, clientes);
    }

    [HttpGet("{id}")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Details([FromRoute] int id)
    {
        var cliente = await _servico.BuscaId(id);
        if (cliente is null) return StatusCode(404);
        return StatusCode(200, cliente);
    }

    [HttpGet("/clientes/cpf/{cpf}")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> DetailsCpf([FromRoute] string cpf)
    {
        var cliente = (await _servico.TodosAsync()).Find(c => c.Cpf == cpf);
        if (cliente is null) return StatusCode(404);
        return StatusCode(200, cliente);
    }

    [HttpPost("")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Create([FromBody] Cliente cliente)
    {
        await _servico.IncluirAsync(cliente);
        return StatusCode(201, cliente);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "adm")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Cliente cliente)
    {
        if (id != cliente.Id)
        {
            return StatusCode(400, new
            {
                Mensagem = "O Id do cliente precisa bater com o id da URL"
            });
        }

        var clienteDb = await _servico.AtualizarAsync(cliente);

        return StatusCode(200, clienteDb);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "adm")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var clienteDb = (await _servico.TodosAsync()).Find(c => c.Id == id);
        if (clienteDb is null)
        {
            return StatusCode(404, new
            {
                Mensagem = "O cliente informado não existe"
            });
        }

        await _servico.ApagarAsync(clienteDb);

        return StatusCode(204);
    }
}