using System.ComponentModel.DataAnnotations.Schema;

namespace Radar_Api.Models;

[Table("PosicoesProdutos")]
public record PosicaoProduto
{
    public int Id {get; set;} = default!;
    public float posicaoX {get; set;} = default!;
    public float posicaoY {get; set;} = default!;
    public int CampanhaId {get; set;} = default!;
}