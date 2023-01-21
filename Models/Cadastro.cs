using System.ComponentModel.DataAnnotations.Schema;

namespace Radar_Api.Models;

[Table("Cadastros")]
public record Cadastro
{
    public int Id {get; set;} = default!;
    public string Nome { get; set; } = default!;
    public string Email {get; set;} = default!;
    public string Senha {get; set;} = default!;
    public string Permissao {get; set;} = default!;
}