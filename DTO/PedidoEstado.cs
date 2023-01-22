using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Radar_Api.DTO;

[Table("v_pedidos_estados")]
[Keyless]
public record PedidoEstado
{
    public string estado { get; set; } = default!;
    public float valor_total_faturado { get; set; } = default!;
    public int qtd_pedidos { get; set; } = default!;

}






