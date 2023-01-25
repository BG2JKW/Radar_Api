using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Radar_Api.Models;

[Table("PedidosProdutos")]
public record PedidoProduto
{
    public int Id {get; set;} = default!;
    public float Valor {get; set;} = default!;
    public int Quantidade {get; set;} = default!;
    public int Pedido_Id {get; set;} = default!;
    public int Produto_Id {get; set;} = default!;

    [ForeignKey("Pedido_Id")]
    [JsonIgnore]
    public virtual Pedido? Pedido { get; set; }
    [ForeignKey("Produto_Id")]
    [JsonIgnore]
    public virtual Produto? Produto { get; set; }
    
}






