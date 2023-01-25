using Radar_Api.Repositories.Context;
using Radar_Api.Interfaces;
using Radar_Api.Models;
using Microsoft.EntityFrameworkCore;
using Radar_Api.DTO;

namespace Radar_Api.Repositories;

public class PedidoCPFRepository : IServico<PedidoCpf>
{
    private EntityContext contexto;
    public PedidoCPFRepository()
    {
        contexto = new EntityContext();
    }
    public async Task<List<PedidoCpf>> TodosAsync()
    {
        return await contexto.PedidosCPF.ToListAsync();
    }

    public Task ApagarAsync(PedidoCpf obj)
    {
        throw new NotImplementedException();
    }

    public Task<PedidoCpf> AtualizarAsync(PedidoCpf obj)
    {
        throw new NotImplementedException();
    }

    public Task<PedidoCpf> BuscaId(int id)
    {
        throw new NotImplementedException();
    }

    public Task IncluirAsync(PedidoCpf obj)
    {
        throw new NotImplementedException();
    }
}