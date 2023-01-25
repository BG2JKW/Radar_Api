using Microsoft.EntityFrameworkCore;
using Radar_Api.Models;
using Radar_Api.Repositories.Context;
using Radar_Api.Interfaces;

namespace api.Repositorios.Entity;

public class PedidoRepository : IServico<Pedido>
{
    private EntityContext contexto;

    public PedidoRepository()
    {
        contexto = new EntityContext();
    }

    public async Task<List<Pedido>> TodosAsync()
    {
        var pedidos = await contexto.Pedidos.ToListAsync();
        return pedidos;
    }

    public async Task<Pedido> BuscaId(int id)
    {
        var pedidos = await contexto.Pedidos.FirstOrDefaultAsync(p => p.Id == id);
        if (pedidos is null) throw new Exception("Pedido não encontrado.");
        return pedidos;
    }

    public async Task IncluirAsync(Pedido pedido)
    {
        contexto.Pedidos.Add(pedido);
        await contexto.SaveChangesAsync();
    }

    public async Task<Pedido> AtualizarAsync(Pedido pedido)
    {
        contexto.Entry(pedido).State = EntityState.Modified;
        await contexto.SaveChangesAsync();

        return pedido;
    }

    public async Task ApagarAsync(Pedido pedido)
    {
        var obj = await contexto.Pedidos.FindAsync(pedido.Id);
        if (obj is null) throw new Exception("Pedido não encontrado.");
        contexto.Pedidos.Remove(obj);
        await contexto.SaveChangesAsync();
    }
    
}