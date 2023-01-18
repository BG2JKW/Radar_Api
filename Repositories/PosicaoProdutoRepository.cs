using Microsoft.EntityFrameworkCore;
using Radar_Api.Models;
using Radar_Api.Repositories.Context;
using Radar_Api.Repositorios.Interfaces;

namespace api.Repositorios.Entity;

public class PosicaoProdutoRepository : IServico<PosicaoProduto>
{
    private EntityContext contexto;

    public PosicaoProdutoRepository()
    {
        contexto = new EntityContext();
    }

    public async Task<List<PosicaoProduto>> TodosAsync()
    {
        return await contexto.PosicoesProdutos.ToListAsync();
    }

    public async Task IncluirAsync(PosicaoProduto posicaoProduto)
    {
        contexto.PosicoesProdutos.Add(posicaoProduto);
        await contexto.SaveChangesAsync();
    }

    public async Task<PosicaoProduto> AtualizarAsync(PosicaoProduto posicaoProduto)
    {
        contexto.Entry(posicaoProduto).State = EntityState.Modified;
        await contexto.SaveChangesAsync();

        return posicaoProduto;
    }

    public async Task ApagarAsync(PosicaoProduto posicaoProduto)
    {
        var obj = await contexto.PosicoesProdutos.FindAsync(posicaoProduto.Id);
        if (obj is null) throw new Exception("Posição do Produto não encontrado.");
        contexto.PosicoesProdutos.Remove(obj);
        await contexto.SaveChangesAsync();
    }
    
}