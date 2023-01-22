using Radar_Api.Repositories.Context;
using Radar_Api.Interfaces;
using Radar_Api.Models;
using Microsoft.EntityFrameworkCore;
using Radar_Api.DTO;

namespace Radar_Api.Repositories;

public class ClienteEstadoRepository : IServico<ClienteEstado>
{
    private EntityContext contexto;
    public ClienteEstadoRepository()
    {
        contexto = new EntityContext();
    }
    public async Task<List<ClienteEstado>> TodosAsync()
    {
        return await contexto.ClientesEstados.ToListAsync();
    }

    public Task ApagarAsync(ClienteEstado obj)
    {
        throw new NotImplementedException();
    }

    public Task<ClienteEstado> AtualizarAsync(ClienteEstado obj)
    {
        throw new NotImplementedException();
    }

    public Task<ClienteEstado> BuscaId(int id)
    {
        throw new NotImplementedException();
    }

    public Task IncluirAsync(ClienteEstado obj)
    {
        throw new NotImplementedException();
    }
}