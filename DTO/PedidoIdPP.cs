using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Radar_Api.DTO;

[Table("v_pedido_info")]
[Keyless]
public record PedidoIdPP
{
        public int Pedido_Id { get; set; } = default!;
}
