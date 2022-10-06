using AutoMapper;
using Manager.API.Configuration;
using Manager.API.ViewModels;
using Manager.Domain.Entities;
using Manager.Infra.Context;
using Manager.Infra.Interfaces;
using Manager.Infra.Repositories;
using Manager.Services.DTO;
using Manager.Services.Interfaces;
using Manager.Services.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEFConfigurations(builder.Configuration);
builder.Services.AddDependencyInjection();

var app = builder.Build();

app.AddPipeLineConfiguration(builder.Environment);

app.MapControllers();

app.Run();