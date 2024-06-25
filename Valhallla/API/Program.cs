using Abstracciones.BC;
using Abstracciones.BW;
using Abstracciones.DA;
using Abstracciones.SG;
using BC;
using BW;
using DA;
using SG;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepositorioDapper, RepositorioDapper>();
builder.Services.AddScoped<IPokemonDA, PokemonDA>();
builder.Services.AddScoped<IEquipoDA, EquipoDA>();
builder.Services.AddScoped<IEntrenadorDA, EntrenadorDA>();

builder.Services.AddScoped<IPokemonSG, PokemonSG>();

builder.Services.AddScoped<IEntrenadorBC, EntrenadorBC>();
builder.Services.AddScoped<IPokemonBC, PokemonBC>();
builder.Services.AddScoped<IEquipoBC, EquipoBC>();

builder.Services.AddScoped<IPokemonBW, PokemonBW>();
builder.Services.AddScoped<IEntrenadorBW, EntrenadorBW>();
builder.Services.AddScoped<IEquipoBW, EquipoBW>();

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