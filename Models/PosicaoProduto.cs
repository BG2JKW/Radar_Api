using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Radar_Api.Models;

[Table("PosicoesProdutos")]
public record PosicaoProduto
{
    public int Id {get; set;} = default!;
    public float posicao_X {get; set;} = default!;
    public float posicao_Y {get; set;} = default!;
    public int Produto_id {get; set;} = default!;
    public int Campanha_Id {get; set;} = default!;

    [ForeignKey("Campanha_Id")]
    [JsonIgnore]
    public virtual Campanha? Campanha { get; set; }
}