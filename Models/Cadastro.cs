using System.ComponentModel.DataAnnotations.Schema;

namespace Radar_Api.Models;

[Table("Cadastros")]
public record Cadastro
{
    public int Id {get; set;} = default!;
    public string? Nome {get; set;}
    public string? Email {get; set;}
    public string? Senha {get; set;}
    public string? Permissao {get; set;}
}