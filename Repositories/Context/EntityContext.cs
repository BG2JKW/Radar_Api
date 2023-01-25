using Microsoft.EntityFrameworkCore;
using Radar_Api.DTO;
using Radar_Api.Models;

namespace Radar_Api.Repositories.Context
{
    public class EntityContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexao = Environment.GetEnvironmentVariable("DATABASE_URL_RADAR");
            //if (conexao is null) conexao = "Server=localhost;Database=api_radar;Uid=root;Pwd=root;";
            if (conexao is null) conexao = "Server=localhost;Database=api_radar;Uid=root;Pwd='root';";
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
        }

        public DbSet<Loja> Lojas { get; set; } = default!;
        public DbSet<Cliente> Clientes { get; set; } = default!;
        public DbSet<Produto> Produtos { get; set; } = default!;
        public DbSet<Pedido> Pedidos { get; set; } = default!;
        public DbSet<PedidoProduto> PedidosProdutos { get; set; } = default!;
        public DbSet<PosicaoProduto> PosicoesProdutos { get; set; } = default!;
        public DbSet<Campanha> Campanhas { get; set; } = default!;
        public DbSet<Cadastro> Cadastros { get; set; } = default!;
        public DbSet<ClienteEstado> ClientesEstados { get; set; } = default!;
        public DbSet<PedidoEstado> PedidosEstados { get; set; } = default!;
        public DbSet<ProdutoInfo> ProdutosInfo { get; set; } = default!;
        public DbSet<PedidoIdPP> PedidosIdPP { get; set; } = default!;
        public DbSet<PedidoCpf> PedidosCPF { get; set; } = default!;
    }
}