namespace Radar_Api.DTO;

public record CadastroDTO
{
    public string Email { get;set; } = default!;

    public string Senha { get;set; } = default!;
}