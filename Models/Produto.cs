using System.ComponentModel.DataAnnotations.Schema;

namespace Radar_Api.Models;

[Table("Produtos")]
public record Produto
{
    public int Id {get; set;} = default!;
    public string Nome {get; set;} = default!;
    public string Descricao {get; set;} = default!; 
    public float Valor {get; set;} = default!; 
    public int QuantidadeEstoque {get; set;} = default!;
}