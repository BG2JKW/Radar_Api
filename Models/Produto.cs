using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Radar_Api.Models;

[Table("Produtos")]
public record Produto
{
    public int Id {get; set;} = default!;
    public string Nome {get; set;} = default!;
    public string? Descricao {get; set;}  
    public float Valor {get; set;} = default!;
    public int Qtd_Estoque {get; set;} = default!;
}