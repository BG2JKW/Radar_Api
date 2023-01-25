namespace Radar_Api.DTO
{
    public record PedidoDTO
    {
        public float Valor_Total { get; set; } = default!;
        public DateTime Data { get; set; } = default!;
        public int Cliente_Id { get; set; } = default!;
    }
}
