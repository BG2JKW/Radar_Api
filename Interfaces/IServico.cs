using Radar_Api.Models;

namespace Radar_Api.Interfaces;

public interface IServico<T>
{
    Task<List<T>> TodosAsync();
    Task<T> BuscaId(int id);
    Task IncluirAsync(T obj);
    Task<T> AtualizarAsync(T obj);
    Task ApagarAsync(T obj);
}