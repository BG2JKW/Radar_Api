using Microsoft.EntityFrameworkCore;
using Radar_Api.Models;
using Radar_Api.Repositories.Context;
using Radar_Api.Repositorios.Interfaces;

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
        var pedidoSql = contexto.Pedidos.Join(
            contexto.Clientes,
            ped => ped.Cliente_Id,
            cli => cli.Id,
            (ped, cli) => new
            {
                PedidoId = ped.Id,
                Valor_Total = ped.Valor_Total,
                Data = ped.Data,
                ClienteNome = cli.Nome,
            }
        ).ToQueryString();

        var pedidoContext = contexto.Pedidos.Include(p => p.Cliente);

        return await pedidoContext.ToListAsync();
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