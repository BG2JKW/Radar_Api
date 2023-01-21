using Microsoft.EntityFrameworkCore;
using Radar_Api.Models;
using Radar_Api.Repositories.Context;
using Radar_Api.Interfaces;

namespace api.Repositorios.Entity;

public class ProdutoRepository : IServico<Produto>
{
    private EntityContext contexto;
    
    public ProdutoRepository()
    {
        contexto = new EntityContext();
    }

    public async Task<List<Produto>> TodosAsync()
    {
        return await contexto.Produtos.ToListAsync();
    }

    public async Task<Produto> BuscaId(int id)
    {
        var obj = await contexto.Produtos.FindAsync(id);
        if (obj is null) throw new Exception("Produto não encontrado.");
        return obj;
    }

    public async Task IncluirAsync(Produto produto)
    {
        contexto.Produtos.Add(produto);
        await contexto.SaveChangesAsync();
    }

    public async Task<Produto> AtualizarAsync(Produto produto)
    {
        contexto.Entry(produto).State = EntityState.Modified;
        await contexto.SaveChangesAsync();

        return produto;
    }

    public async Task ApagarAsync(Produto produto)
    {
        var obj = await contexto.Produtos.FindAsync(produto.Id);
        if (obj is null) throw new Exception("Produto não encontrado.");
        contexto.Produtos.Remove(obj);
        await contexto.SaveChangesAsync();
    }
}