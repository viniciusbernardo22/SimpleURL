using Microsoft.EntityFrameworkCore;
using SimpleURL.Data.Data;
using SimpleURL.Data.Interfaces;
using SimpleURL.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("SimpleURLDB"));

builder.Services.AddScoped<IUrlRepository, UrlRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.MapControllers();
app.UseHttpsRedirection();

app.Run();

