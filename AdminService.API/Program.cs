using Microsoft.EntityFrameworkCore;
using AdminService.Infrastructure.Data;
using AdminService.Infrastructure.Repository.Interfaces;
using AdminService.Application.Services;
using AdminService.Application.Interfaces;
using AdminService.Application.MappingProfiles;
//using AdminService.Application.MappingProfiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AdminServiceDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("AdminServiceConnectionString")));

//builder.Services.AddScoped<IRepository,Repository>
// Fix: Add missing semicolon and correct the generic type registration syntax
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IAuditService, AuditService>();
builder.Services.AddAutoMapper(typeof(AuditProfiles).Assembly);

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
