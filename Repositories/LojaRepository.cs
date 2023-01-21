using Microsoft.EntityFrameworkCore;
using Radar_Api.Models;
using Radar_Api.Repositories.Context;
using Radar_Api.Interfaces;

namespace Radar_Api.Repositories
{
    public class LojaRepository : IServico<Loja>
    {
        private EntityContext contexto;
        public LojaRepository()
        {
            contexto = new EntityContext();
        }

        public async Task<List<Loja>> TodosAsync()
        {
            return await contexto.Lojas.ToListAsync();
        }

        public async Task<Loja> BuscaId(int id)
        {
            var obj = await contexto.Lojas.FindAsync(id);
            if (obj is null) throw new Exception("Loja não encontrada.");
            return obj;
        }

        public async Task IncluirAsync(Loja loja)
        {
            contexto.Lojas.Add(loja);
            await contexto.SaveChangesAsync();
        }

        public async Task<Loja> AtualizarAsync(Loja loja)
        {
            contexto.Entry(loja).State = EntityState.Modified;
            await contexto.SaveChangesAsync();

            return loja;
        }

        public async Task ApagarAsync(Loja loja)
        {
            var obj = await contexto.Lojas.FindAsync(loja.Id);
            if (obj is null) throw new Exception("Loja não encontrada.");
            contexto.Lojas.Remove(obj);
            await contexto.SaveChangesAsync();
        }
    }
}
