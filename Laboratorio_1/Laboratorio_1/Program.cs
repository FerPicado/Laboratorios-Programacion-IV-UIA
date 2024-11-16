using DotNetEnv;
using MatriculaService.Controllers;
using MatriculaService.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Env.Load();

//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
//    .Replace("{DB_SERVER}", Environment.GetEnvironmentVariable("DB_SERVER"))
//    .Replace("{DB}", Environment.GetEnvironmentVariable("DB"))
//    .Replace("{DB_USER}", Environment.GetEnvironmentVariable("DB_USER"))
//    .Replace("{DB_PASSWORD}", Environment.GetEnvironmentVariable("DB_PASSWORD"));

//builder.Services.AddDbContext<MyDbContext>(options =>
//    options.UseSqlServer(connectionString)
//);

builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMatricula, MatriculaSystem>();
builder.Services.AddScoped<IMatriculaEstudianteRepository, MatriculaRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
