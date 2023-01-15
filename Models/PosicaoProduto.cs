namespace Radar_Api.Models;

public record PosicaoProduto
{
    public int Id {get; set;} = default!;
    public int CampanhaId {get; set;} = default!;
    public int posicaoX {get; set;} = default!;
    public int posicaoY {get; set;} = default!;
}