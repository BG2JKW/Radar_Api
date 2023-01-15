namespace Radar_Api.Models;

public record Cliente
{
    public int Id {get; set;} = default!;
    public string Nome {get; set;} = default!;
    public string? Telefone {get; set;}
    public string Email {get; set;} = default!;
    public string Cpf {get; set;} = default!;
    public int Cep {get; set;}
    public string? Logradouro {get; set;}
    public int Numero {get; set;}
    public string? Bairro {get; set;}
    public string? Cidade {get; set;}
    public string? Estado {get; set;}
    public string? Complemento {get; set;}
}




