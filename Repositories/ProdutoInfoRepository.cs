using Radar_Api.Repositories.Context;
using Radar_Api.Interfaces;
using Radar_Api.Models;
using Microsoft.EntityFrameworkCore;
using Radar_Api.DTO;

namespace Radar_Api.Repositories;

public class ProdutoInfoRepository : IServico<ProdutoInfo>
{
    private EntityContext contexto;
    public ProdutoInfoRepository()
    {
        contexto = new EntityContext();
    }
    public async Task<List<ProdutoInfo>> TodosAsync()
    {
        return await contexto.ProdutosInfo.ToListAsync();
    }

    public Task ApagarAsync(ProdutoInfo obj)
    {
        throw new NotImplementedException();
    }

    public Task<ProdutoInfo> AtualizarAsync(ProdutoInfo obj)
    {
        throw new NotImplementedException();
    }

    public Task<ProdutoInfo> BuscaId(int id)
    {
        throw new NotImplementedException();
    }

    public Task IncluirAsync(ProdutoInfo obj)
    {
        throw new NotImplementedException();
    }
}