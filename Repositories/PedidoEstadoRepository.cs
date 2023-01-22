using Radar_Api.Repositories.Context;
using Radar_Api.Interfaces;
using Radar_Api.Models;
using Microsoft.EntityFrameworkCore;
using Radar_Api.DTO;

namespace Radar_Api.Repositories;

public class PedidoEstadoRepository : IServico<PedidoEstado>
{
    private EntityContext contexto;
    public PedidoEstadoRepository()
    {
        contexto = new EntityContext();
    }
    public async Task<List<PedidoEstado>> TodosAsync()
    {
        return await contexto.PedidosEstados.ToListAsync();
    }

    public Task ApagarAsync(PedidoEstado obj)
    {
        throw new NotImplementedException();
    }

    public Task<PedidoEstado> AtualizarAsync(PedidoEstado obj)
    {
        throw new NotImplementedException();
    }

    public Task<PedidoEstado> BuscaId(int id)
    {
        throw new NotImplementedException();
    }

    public Task IncluirAsync(PedidoEstado obj)
    {
        throw new NotImplementedException();
    }
}