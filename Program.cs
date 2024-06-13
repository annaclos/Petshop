using Petshop.Data;
using Petshop.src.Contracts.Repository;
using Petshop.src.Contracts.Service;
using Petshop.src.Repository;
using Petshop.src.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAnimalRepository, AnimaisRepository>();
builder.Services.AddScoped<IAnimalService, AnimaisService>();
builder.Services.AddScoped<IClientesService, ClientesService>();
builder.Services.AddScoped<IClientesRepository, ClientesRepository>();
builder.Services.AddScoped<IServicosRepository, ServicosRepository>();
builder.Services.AddScoped<IServicosService, ServicosService>();
builder.Services.AddSingleton<DapperContext>();

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
