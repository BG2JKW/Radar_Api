using System.ComponentModel.DataAnnotations.Schema;

namespace Radar_Api.Models;

[Table("Lojas")]
public record Loja
{
    public int Id {get; set;} = default!;
    public string Nome {get; set;} = default!;
    public string? Observacao {get; set;} 
    public string Cep {get; set;} = default!;
    public string Logradouro {get; set;} = default!;
    public string Numero {get; set;} = default!;
    public string Bairro {get; set;} = default!;
    public string Cidade {get; set;} = default!;
    public string Estado {get; set;} = default!;
    public string? Complemento {get; set;} 
    public float Latitude {get; set;} = default!;
    public float Longitude {get; set;} = default!;
}