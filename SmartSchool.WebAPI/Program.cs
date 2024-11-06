using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

// Add services to the container.

services.AddDbContext<DataContext>(context =>
    context.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
services.AddControllers();
// Swagger/OpenAPI
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var app = builder.Build();

// HTTP request pipeline config
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
