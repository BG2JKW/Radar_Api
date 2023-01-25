using Microsoft.EntityFrameworkCore;
using Radar_Api.Models;
using Radar_Api.Repositories.Context;
using Radar_Api.Interfaces;

namespace api.Repositorios.Entity;

public class PedidoProdutoRepository : IServico<PedidoProduto>
{
    private EntityContext contexto;

    public PedidoProdutoRepository()
    {
        contexto = new EntityContext();
    }

    public async Task<List<PedidoProduto>> TodosAsync()
    {
        var pedidosProdutos = await contexto.PedidosProdutos.ToListAsync();
        return pedidosProdutos;
    }

    public async Task<PedidoProduto> BuscaId(int id)
    {
        var pedidosProdutos = await contexto.PedidosProdutos.FirstOrDefaultAsync(pp => pp.Id == id);
            .Include(pp => pp.Produto)
            .FirstOrDefaultAsync(pp => pp.Id == id);
        if (pedidosProdutos is null) throw new Exception("PedidoProduto não encontrado.");
        return pedidosProdutos;
    }

    public async Task IncluirAsync(PedidoProduto pedidoProduto)
    {
        contexto.PedidosProdutos.Add(pedidoProduto);
        await contexto.SaveChangesAsync();
    }

    public async Task<PedidoProduto> AtualizarAsync(PedidoProduto pedidoProduto)
    {
        contexto.Entry(pedidoProduto).State = EntityState.Modified;
        await contexto.SaveChangesAsync();

        return pedidoProduto;
    }

    public async Task ApagarAsync(PedidoProduto pedidoProduto)
    {
        var obj = await contexto.PedidosProdutos.FindAsync(pedidoProduto.Id);
        if (obj is null) throw new Exception("Não localizado");
        contexto.PedidosProdutos.Remove(obj);
        await contexto.SaveChangesAsync();
    }
    
}