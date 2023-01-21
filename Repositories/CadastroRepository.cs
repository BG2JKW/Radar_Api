using Radar_Api.Repositories.Context;
using Radar_Api.Interfaces;
using Radar_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Radar_Api.Repositories;

public class CadastroRepository : IServicoCadastro<Cadastro>
{
    private EntityContext contexto;
    public CadastroRepository()
    {
        contexto = new EntityContext();
    }

    public async Task<List<Cadastro>> TodosAsync()
    {
        return await contexto.Cadastros.ToListAsync();
    }

    public async Task<Cadastro> BuscaId(int id)
    {
        var obj = await contexto.Cadastros.FindAsync(id);
        if (obj is null) throw new Exception("Cadastro não encontrado.");
        return obj;
    }

    public async Task<Cadastro?> Login(string email, string senha)
    {
        return await contexto.Cadastros.Where(c => c.Email == email && c.Senha == senha).FirstOrDefaultAsync();
    }

    public async Task IncluirAsync(Cadastro cadastro)
    {
        contexto.Cadastros.Add(cadastro);
        await contexto.SaveChangesAsync();
    }

    public async Task<Cadastro> AtualizarAsync(Cadastro cadastro)
    {
        contexto.Entry(cadastro).State = EntityState.Modified;
        await contexto.SaveChangesAsync();

        return cadastro;
    }

    public async Task ApagarAsync(Cadastro cadastro)
    {
        var obj = await contexto.Cadastros.FindAsync(cadastro.Id);
        if(obj is null) throw new Exception("cadastro não encontrado");
        contexto.Cadastros.Remove(obj);
        await contexto.SaveChangesAsync();
    }
}