namespace Radar_Api.Interfaces;

public interface IServicoCadastro<T> : IServico<T>
{
    Task<T?> Login(string email, string senha);
}