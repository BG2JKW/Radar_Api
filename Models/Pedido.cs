using System.ComponentModel.DataAnnotations.Schema;

namespace Radar_Api.Models;

[Table("Pedidos")]
public record Pedido
{
    public int Id {get; set;}
    public int ClienteId {get; set;} = default!;
    public float ValorTotal {get; set;}
    public DateTime Data {get; set;}
}







 