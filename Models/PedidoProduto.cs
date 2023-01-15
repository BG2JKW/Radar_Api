namespace Radar_Api.Models;

public record PedidoProduto
{
    public int Id {get; set;} = default!;
    public int PedidoId {get; set;} = default!;
    public int ProdutoId {get; set;} = default!;
    public int Valor {get; set;}
    public int Quantidade {get; set;}
}






