namespace Radar_Api.Models;

public record Produto
{
    public int Id {get; set;} = default!;
    public string Nome {get; set;} = default!;
    public string Descricao {get; set;} = default!; 
    public int Valor {get; set;} = default!; 
    public int QuantidadeEstoque {get; set;} = default!;
}