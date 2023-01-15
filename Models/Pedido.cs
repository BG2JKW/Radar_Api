namespace Radar_Api.Models;

public record Pedido
{
    public int Id {get; set;} = default!;
    public int ClienteId {get; set;} = default!;
    public int ValorTotal {get; set;}
    public DateOnly Data {get; set;}
}







 