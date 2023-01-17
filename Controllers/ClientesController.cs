using Microsoft.AspNetCore.Mvc;
using Radar_Api.Models;
using Radar_Api.Repositorios.Interfaces;

namespace api.Controllers;

[Route("clientes")]
public class ClientesController : ControllerBase
{
    private IServico<Cliente> _servico;
    public ClientesController(IServico<Cliente> servico)
    {
        _servico = servico;
    }

    [HttpGet("")]
    public async Task<IActionResult> Index()
    {
        var clientes = await _servico.TodosAsync();
        return StatusCode(200, clientes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Details([FromRoute] int id)
    {
        var cliente = (await _servico.TodosAsync()).Find(c => c.Id == id);

        return StatusCode(200, cliente);
    }

    [HttpPost("")]
    public async Task<IActionResult> Create([FromBody] Cliente cliente)
    {
        await _servico.IncluirAsync(cliente);
        return StatusCode(201, cliente);
    }

    [HttpPut("{id}")]
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