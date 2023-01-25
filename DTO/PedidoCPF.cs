using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Radar_Api.DTO;

[Table("v_pedidos_cpf")]
[Keyless]
public record PedidoCpf
{
    public int id { get; set; } = default!;
    public float valor_total { get; set; } = default!;
    public DateTime data { get; set; } = default!;
    public string cpf { get; set; } = default!;
}
