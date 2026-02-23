using MediatR;
using Microsoft.EntityFrameworkCore;
using UMS.CleanArch.Domain.Commands;
using UMS.CleanArch.Infra.Data.Context;
using UMS.CleanArch.Infra.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var universityConnectionString = builder.Configuration.GetConnectionString("UniversityDBConnection") ?? throw new InvalidOperationException("Connection string 'UniversityDBConnection' not found.");

// Business DB
builder.Services.AddDbContext<UniversityDbContext>(options =>
    options.UseSqlServer(universityConnectionString));

// Add MediatR
builder.Services.AddMediatR((typeof(CourseCommand).Assembly));

DependencyContainer.RegisterServices(builder.Services);

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
