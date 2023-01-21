using Microsoft.AspNetCore.Mvc;
using Radar_Api.Models;
using Radar_Api.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace api.Controllers;

[Route("campanhas")]
[ApiController]

public class CampanhasController : ControllerBase
{
    private IServico<Campanha> _servico;

    public CampanhasController(IServico<Campanha> servico)
    {
        _servico = servico;
    }

    [HttpGet("")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Index()
    {
        var campanhas = await _servico.TodosAsync();
        return StatusCode(200, campanhas);
    }

    [HttpGet("{id}")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Details([FromRoute] int id)
    {
        var campanha = (await _servico.TodosAsync()).Find(c => c.Id == id);

        return StatusCode(200, campanha );
    }

    [HttpPost("")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Create([FromBody] Campanha campanha)
    {
        await _servico.IncluirAsync(campanha);
        return StatusCode(201, campanha);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "adm")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Campanha campanha)
    {
        if (id != campanha.Id)
        {
            return StatusCode(400, new
            {
                Mensagem = "O Id da campanha precisa bater com o id da URL"
            });
        }

        var campanhaDb = await _servico.AtualizarAsync(campanha);

        return StatusCode(200, campanhaDb);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "adm")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var campanhaDb = (await _servico.TodosAsync()).Find(c => c.Id == id);
        if (campanhaDb is null)
        {
            return StatusCode(404, new
            {
                Mensagem = "A campanha informada não existe"
            });
        }

        await _servico.ApagarAsync(campanhaDb);

        return StatusCode(204);
    }
    
}