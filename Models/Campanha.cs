using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Radar_Api.Models;

[Table("Campanhas")]
public record Campanha
{
    public int Id {get; set;} = default!;
    public string Nome {get; set;} = default!;
    public string Descricao {get; set;} = default!;
    public DateTime Data {get; set;} = default!;
    public string Url_Foto_Prateleira {get; set;} = default!;

    [JsonIgnore]
    public virtual ICollection<PosicaoProduto> PosicoesProdutos { get; set; }
}