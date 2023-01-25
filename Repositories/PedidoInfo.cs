using Radar_Api.Repositories.Context;
using Radar_Api.Interfaces;
using Radar_Api.Models;
using Microsoft.EntityFrameworkCore;
using Radar_Api.DTO;

namespace Radar_Api.Repositories;

public class PedidoInfo : IServico<PedidoIdPP>
{
    private EntityContext contexto;
    public PedidoInfo()
    {
        contexto = new EntityContext();
    }

    public async Task<List<PedidoIdPP>> TodosAsync()
    {
        return await contexto.PedidosIdPP.ToListAsync();
    }

    public Task ApagarAsync(PedidoIdPP obj)
    {
        throw new NotImplementedException();
    }

    public Task<PedidoIdPP> AtualizarAsync(PedidoIdPP obj)
    {
        throw new NotImplementedException();
    }

    public async Task<PedidoIdPP> BuscaId(int id)
    {
        var pedido_id = await contexto.PedidosIdPP.FindAsync(id);
        return pedido_id;
    }

    public Task IncluirAsync(PedidoIdPP obj)
    {
        throw new NotImplementedException();
    }
}