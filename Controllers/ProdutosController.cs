using Microsoft.AspNetCore.Mvc;
using Radar_Api.Models;
using Radar_Api.Repositorios.Interfaces;

namespace api.Controllers;

[Route("produtos")]
public class ProdutosController : ControllerBase
{
    private IServico<Produto> _servico;

    public ProdutosController(IServico<Produto> servico)
    {
        _servico = servico;
    }

    [HttpGet("")]
    public async Task<IActionResult> Index()
    {
        var produtos = await _servico.TodosAsync();
        return StatusCode(200, produtos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Details([FromRoute] int id)
    {
        var produto = (await _servico.TodosAsync()).Find(c => c.Id == id);

        return StatusCode(200, produto);
    }

    [HttpPost("")]
    public async Task<IActionResult> Create([FromBody] Produto produto)
    {
        await _servico.IncluirAsync(produto);
        return StatusCode(201, produto);
    }

    [HttpPut("{id}")]
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