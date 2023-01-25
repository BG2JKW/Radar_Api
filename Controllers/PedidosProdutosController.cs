using Microsoft.AspNetCore.Mvc;
using Radar_Api.Models;
using Radar_Api.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace api.Controllers;

[Route("pedidosProdutos")]
[ApiController]
public class PedidosProdutosController : ControllerBase
{
    private IServico<PedidoProduto> _servico;

    public PedidosProdutosController(IServico<PedidoProduto> servico)
    {
        _servico = servico;
    }

    [HttpGet("")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Index()
    {
        var pedidosProdutos = await _servico.TodosAsync();
        if (pedidosProdutos == null)
        {
            return NotFound();
        }
        return Ok(pedidosProdutos);
    }
    
    [HttpGet("{id}")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Details([FromRoute] int id)
    {
        var pedidoProduto = await _servico.BuscaId(id);

        return StatusCode(200, pedidoProduto);
    }
    
    [HttpGet("/pedidosProdutos/pedidoId/{id}")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> DetailsIdPedido([FromRoute] int id)
    {
        var pedidosProdutosDoPedido = new List<PedidoProduto>();
        List<PedidoProduto> todosPedidosProduto = await _servico.TodosAsync();
        for(int i = 0; i<todosPedidosProduto.Count; i++)
        {
            var pedidoProdutoBD = todosPedidosProduto[i];
            if (pedidoProdutoBD.Pedido_Id.ToString() == id.ToString())
            {
                pedidosProdutosDoPedido.Add(pedidoProdutoBD);
            }
        }
        if (pedidosProdutosDoPedido.Count == 0) return NotFound();
        return StatusCode(200, pedidosProdutosDoPedido);
    }

    [HttpPost("")]
    [Authorize(Roles = "adm,editor")]
    public async Task<IActionResult> Create([FromBody] PedidoProduto pedidoProduto)
    {
        await _servico.IncluirAsync(pedidoProduto);
        return StatusCode(201, pedidoProduto);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "adm")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] PedidoProduto pedidoProduto)
    {
        if (id != pedidoProduto.Id)
        {
            return StatusCode(400, new
            {
                Mensagem = "O Id precisa bater com o id da URL"
            });
        }

        var pedidoProdutoDb = await _servico.AtualizarAsync(pedidoProduto);

        return StatusCode(200, pedidoProdutoDb);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "adm")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var pedidoProdutoDb = (await _servico.TodosAsync()).Find(c => c.Id == id);
        if (pedidoProdutoDb is null)
        {
            return StatusCode(404, new
            {
                Mensagem = "Não localizado"
            });
        }

        await _servico.ApagarAsync(pedidoProdutoDb);

        return StatusCode(204);
    }
}