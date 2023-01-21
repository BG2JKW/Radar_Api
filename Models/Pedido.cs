using System.ComponentModel.DataAnnotations.Schema;

namespace Radar_Api.Models;

[Table("Pedidos")]
public record Pedido
{
    public int Id {get; set;}  = default!;
    public float Valor_Total {get; set;} = default!;
    public DateTime Data {get; set;} = default!;
    public int Cliente_Id {get; set;} = default!;
}







 