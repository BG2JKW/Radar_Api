using System.ComponentModel.DataAnnotations.Schema;

namespace Radar_Api.DTO;

[Table("v_clientes_estados")]
public record ClienteEstado
{
    public string estado { get; set; } = default!;
    public int qtd_clientes { get; set; } = default!;

}






