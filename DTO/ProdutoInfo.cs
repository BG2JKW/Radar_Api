using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Radar_Api.DTO;

[Table("v_produtos_info")]
[Keyless]
public record ProdutoInfo
{
    public string nome { get; set; } = default!;
    public int qtd_total_vendida { get; set; } = default!;
    public float faturamento_total { get; set; } = default!;
    public int qtd_estoque { get; set; } = default!;
}