using System.ComponentModel.DataAnnotations.Schema;

namespace Radar_Api.Models;

[Table("PosicoesProdutos")]
public record PosicaoProduto
{
    public int Id {get; set;} = default!;
    public float posicao_X {get; set;} = default!;
    public float posicao_Y {get; set;} = default!;
    public int Produto_id {get; set;} = default!;
    public int Campanha_Id {get; set;} = default!;
}