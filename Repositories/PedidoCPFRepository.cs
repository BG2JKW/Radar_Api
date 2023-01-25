using Radar_Api.Repositories.Context;
using Radar_Api.Interfaces;
using Radar_Api.Models;
using Microsoft.EntityFrameworkCore;
using Radar_Api.DTO;

namespace Radar_Api.Repositories;

public class PedidoCPFRepository : IServico<PedidoCPF>
{
    private EntityContext contexto;
    public PedidoCPFRepository()
    {
        contexto = new EntityContext();
    }
    public async Task<List<PedidoCPF>> TodosAsync()
    {
        return await contexto.PedidosCPF.ToListAsync();
    }

    public Task ApagarAsync(PedidoCPF obj)
    {
        throw new NotImplementedException();
    }

    public Task<PedidoCPF> AtualizarAsync(PedidoCPF obj)
    {
        throw new NotImplementedException();
    }

    public Task<PedidoCPF> BuscaId(int id)
    {
        throw new NotImplementedException();
    }

    public Task IncluirAsync(PedidoCPF obj)
    {
        throw new NotImplementedException();
    }
}