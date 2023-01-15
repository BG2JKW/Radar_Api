namespace Radar_Api.Models;

public record Loja
{
    public int Id {get; set;} = default!;
    public string Nome {get; set;} = default!;
    public string Observacao {get; set;} = default!;
    public int Cep {get; set;} = default!;
    public string Logradouro {get; set;} = default!;
    public int Numero {get; set;} = default!;
    public string Bairro {get; set;} = default!;
    public string Cidade {get; set;} = default!;
    public string Estado {get; set;} = default!;
    public string Complemento {get; set;} = default!;
    public string Latitude {get; set;} = default!;
    public string Longitude {get; set;} = default!;
}


