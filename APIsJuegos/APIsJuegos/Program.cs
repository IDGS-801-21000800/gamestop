using APIsJuegos.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var constrin = builder.Configuration.GetConnectionString("connString");
builder.Services.AddDbContext<JuegosContext>(options => options.UseSqlServer(constrin));

//cors Cross-origin Resource Sharing (USO COMPARTIDO DE RECURSOS ENTRE ORIGENES)
builder.Services.AddCors(options =>
{
    options.AddPolicy("NUEVAPOLITICA", app =>
    {
        app.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("NUEVAPOLITICA");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
