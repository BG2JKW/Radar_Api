using Microsoft.AspNetCore.Mvc;
using Radar_Api.Models;
using Radar_Api.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace api.Controllers;

[Route("produtos")]
[ApiController]
public class ProdutosController : ControllerBase
{
    private IServico<Produto> _servico;

    public ProdutosController(IServico<Produto> servico)
    {
        _servico = servico;
    }

    [HttpGet("")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Index()
    {
        var produtos = await _servico.TodosAsync();
        return StatusCode(200, produtos);
    }

    [HttpGet("{id}")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Details([FromRoute] int id)
    {
        var produto = (await _servico.TodosAsync()).Find(c => c.Id == id);
        if (produto == null) return StatusCode(404, "Produto Não Encontrado");
        return StatusCode(200, produto);
    }

    [HttpPost("")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Create([FromBody] Produto produto)
    {
        await _servico.IncluirAsync(produto);
        return StatusCode(201, produto);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "adm")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Produto produto)
    {
        if (id != produto.Id)
        {
            return StatusCode(400, new
            {
                Mensagem = "O Id do produto precisa bater com o id da URL"
            });
        }

        var produtoDb = await _servico.AtualizarAsync(produto);

        return StatusCode(200, produtoDb);
    }
    [HttpDelete("{id}")]
    [Authorize(Roles = "adm")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var produtoDb = (await _servico.TodosAsync()).Find(c => c.Id == id);
        if (produtoDb is null)
        {
            return StatusCode(404, new
            {
                Mensagem = "O produto informado não existe"
            });
        }

        await _servico.ApagarAsync(produtoDb);

        return StatusCode(204);
    }

}