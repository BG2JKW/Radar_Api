using api.Repositorios.Entity;
using Radar_Api.Models;
using Radar_Api.Repositories;
using Radar_Api.Repositorios.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IServico<Cliente>, ClienteRepository>();
builder.Services.AddScoped<IServico<Loja>, LojaRepository>();
builder.Services.AddScoped<IServico<Produto>, ProdutoRepository>();
builder.Services.AddScoped<IServico<Pedido>, PedidoRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
