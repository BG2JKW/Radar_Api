using System.ComponentModel.DataAnnotations.Schema;

namespace Radar_Api.Models;

[Table("Campanhas")]
public record Campanha
{
    public int Id {get; set;} = default!;
    public string? Nome {get; set;}
    public string? Descricao {get; set;}
    public DateTime Data {get; set;}
    public string? Url_Foto_Prateleira {get; set;}
}