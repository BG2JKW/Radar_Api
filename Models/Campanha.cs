namespace Radar_Api.Models;

public record Campanha
{
    public int Id {get; set;} = default!;
    public string Nome {get; set;} = default!;
    public string? Descricao {get; set;}
    public DateOnly Data {get; set;}
    public string? UrlFotoPrateleira {get; set;}
}





