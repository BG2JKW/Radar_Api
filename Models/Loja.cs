using System.ComponentModel.DataAnnotations.Schema;

namespace Radar_Api.Models;

[Table("Lojas")]
public record Loja
{
    public int Id {get; set;} = default!;
    public string? Nome {get; set;} 
    public string? Observacao {get; set;} 
    public string? Cep {get; set;} 
    public string? Logradouro {get; set;} 
    public string? Numero {get; set;} 
    public string? Bairro {get; set;} 
    public string? Cidade {get; set;} 
    public string? Estado {get; set;} 
    public string? Complemento {get; set;} 
    public float Latitude {get; set;} 
    public float Longitude {get; set;} 
}


