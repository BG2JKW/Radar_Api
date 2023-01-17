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
    public string? Cep {get; set;}
    public string? Logradouro {get; set;}
    public string? Numero {get; set;}
    public string? Bairro {get; set;}
    public string? Cidade {get; set;}
    public string? Estado {get; set;}
    public string? Complemento {get; set;}
}




