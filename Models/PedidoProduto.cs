using System.ComponentModel.DataAnnotations.Schema;

namespace Radar_Api.Models;

[Table("PedidosProdutos")]
public record PedidoProduto
{
    public int Id {get; set;} = default!;
    public float Valor {get; set;}
    public int Quantidade {get; set;}
    public int PedidoId {get; set;} = default!;
    public int Produto_Id {get; set;} = default!;
    
    
}






