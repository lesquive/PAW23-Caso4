using Microsoft.EntityFrameworkCore;
//using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using AutoFixRepairAPI.Services;
using AutoFixRepairAPI.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost", builder =>
    {
        builder.WithOrigins("http://localhost:3000", "http://localhost:7279", "http://localhost:7184", "http://localhost")
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Services.AddDbContext<AutoFixDbContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("AutoFixDbContext"), new MySqlServerVersion(new Version(8, 0, 25)));
});

builder.Services.AddScoped<InformacionServiciosServices>();
builder.Services.AddScoped<ClienteServices>();
builder.Services.AddScoped<SolicitudReparacionServices>();
builder.Services.AddScoped<TipoReparacionServices>();
builder.Services.AddScoped<AsignacionSolicitudService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowLocalhost");

app.UseAuthorization();

app.MapControllers();

app.Run();