using Microsoft.EntityFrameworkCore;
using Radar_Api.Models;
using Radar_Api.Repositories.Context;
using Radar_Api.Interfaces;

namespace api.Repositorios.Entity;

public class ClienteRepository : IServico<Cliente>
{
    private EntityContext contexto;
    public ClienteRepository()
    {
        contexto = new EntityContext();
    }

    public async Task<List<Cliente>> TodosAsync()
    {
        return await contexto.Clientes.ToListAsync();
    }

    public async Task<Cliente> BuscaId(int id)
    {
        var obj = await contexto.Clientes.FindAsync(id);
        return obj;
    }

    public async Task IncluirAsync(Cliente cliente)
    {
        if (cliente is null) throw new Exception("Cliente não encontrado.");
        contexto.Clientes.Add(cliente);
        await contexto.SaveChangesAsync();
    }

    public async Task<Cliente> AtualizarAsync(Cliente cliente)
    {
        contexto.Entry(cliente).State = EntityState.Modified;
        await contexto.SaveChangesAsync();

        if (cliente is null) throw new Exception("Cliente não encontrado.");

        return cliente;
    }

    public async Task ApagarAsync(Cliente cliente)
    {
        var obj = await contexto.Clientes.FindAsync(cliente.Id);
        if (obj is null) throw new Exception("Cliente não encontrado.");
        contexto.Clientes.Remove(obj);
        await contexto.SaveChangesAsync();
    }
}