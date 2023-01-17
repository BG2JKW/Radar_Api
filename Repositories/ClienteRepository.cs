using Microsoft.EntityFrameworkCore;
using Radar_Api.Models;
using Radar_Api.Repositories.Context;
using Radar_Api.Repositorios.Interfaces;

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

    public async Task IncluirAsync(Cliente cliente)
    {
        contexto.Clientes.Add(cliente);
        await contexto.SaveChangesAsync();
    }

    public async Task<Cliente> AtualizarAsync(Cliente cliente)
    {
        contexto.Entry(cliente).State = EntityState.Modified;
        await contexto.SaveChangesAsync();

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