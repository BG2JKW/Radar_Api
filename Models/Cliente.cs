using System.ComponentModel.DataAnnotations.Schema;

namespace Radar_Api.Models;

[Table("Clientes")]
public record Cliente
{
    public int Id {get; set;} = default!;
    public string Nome {get; set;} = default!;
    public string? Telefone {get; set;}
    public string Email {get; set;} = default!;
    public string Cpf {get; set;} = default!;
    public string Cep {get; set;} = default!;
    public string Logradouro {get; set;} = default!;
    public string? Numero {get; set;}
    public string? Bairro {get; set;}
    public string Cidade {get; set;} = default!;
    public string Estado {get; set;} = default!;
    public string? Complemento {get; set;}
}




