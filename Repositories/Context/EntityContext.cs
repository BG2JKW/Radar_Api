﻿using Microsoft.EntityFrameworkCore;
using Radar_Api.Models;

namespace Radar_Api.Repositories.Context
{
    public class EntityContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexao = Environment.GetEnvironmentVariable("DATABASE_URL_RADAR");
            //if (conexao is null) conexao = "Server=localhost;Database=api_radar;Uid=root;Pwd=root;";
            if (conexao is null) conexao = "Server=localhost;Database=api_radar;Uid=root;Pwd='';";
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
        }

        public DbSet<Loja> Lojas { get; set; } = default!;
        public DbSet<Cliente> Clientes { get; set; } = default!;
        public DbSet<Produto> Produtos { get; set; } = default!;
        public DbSet<Pedido> Pedidos { get; set; } = default!;
    }
}