using api.Repositorios.Entity;
using Microsoft.OpenApi.Models;
using Radar_Api.Models;
using Radar_Api.Repositories;
using Radar_Api.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Radar_Api.Autenticacao;
using Radar_Api.DTO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IServico<Cliente>, ClienteRepository>();
builder.Services.AddScoped<IServico<Loja>, LojaRepository>();
builder.Services.AddScoped<IServico<Produto>, ProdutoRepository>();
builder.Services.AddScoped<IServico<Pedido>, PedidoRepository>();
builder.Services.AddScoped<IServico<PedidoProduto>, PedidoProdutoRepository>();
builder.Services.AddScoped<IServico<PosicaoProduto>, PosicaoProdutoRepository>();
builder.Services.AddScoped<IServico<Campanha>, CampanhaRepository>();
builder.Services.AddScoped<IServicoCadastro<Cadastro>, CadastroRepository>();
builder.Services.AddScoped<IServico<ClienteEstado>, ClienteEstadoRepository>();
builder.Services.AddScoped<IServico<PedidoEstado>, PedidoEstadoRepository>();
builder.Services.AddScoped<IServico<ProdutoInfo>, ProdutoInfoRepository>();
builder.Services.AddScoped<IServico<PedidoCpf>, PedidoCPFRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "API Radar", Version = "v1" });
    opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "bearer"
    });
    opt.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});

builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(UserToken.Key)),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("adm", policy => policy.RequireClaim("adm"));
    options.AddPolicy("editor", policy => policy.RequireClaim("editor"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//RESOLVENDO PROBLEMA DE CROSS DOMAIN
app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
);

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
