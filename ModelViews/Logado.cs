namespace Radar_Api.ModelViews;

public record Logado
{
    public int Id { get;set; } = default!;
    public string Nome { get;set; } = default!;
    public string Email { get;set; } = default!;
    public string Permissao { get;set; } = default!;
    public string Token { get;set; } = default!;
}