using Microsoft.EntityFrameworkCore;
using Radar_Api.Models;
using Radar_Api.Repositories.Context;
using Radar_Api.Interfaces;

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
        var posicoes = await Task.FromResult
        (
            from pos in contexto.PosicoesProdutos
            join prod in contexto.Produtos on pos.Produto_id equals prod.Id
            join camp in contexto.Campanhas on pos.Campanha_Id equals camp.Id
            select new PosicaoProduto
            {
                Id = pos.Id,
                posicao_X = pos.posicao_X,
                posicao_Y = pos.posicao_Y,
                Produto_id = prod.Id,
                Campanha_Id = camp.Id,
            }
        );

        return await posicoes.ToListAsync();
    }

    public async Task<PosicaoProduto> BuscaId(int id)
    {
        var obj = await contexto.PosicoesProdutos.FindAsync(id);
        if (obj is null) throw new Exception("PosicaoProduto não encontrado.");
        return obj;
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