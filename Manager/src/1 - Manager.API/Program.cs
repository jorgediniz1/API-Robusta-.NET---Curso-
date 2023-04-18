  using Manager.API.ConfigurationStartup;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEFConfigurations(builder.Configuration);
builder.Services.AddDependencyInjection(builder.Configuration);

var app = builder.Build();

app.AddPipeLineConfiguration(builder.Environment);

app.MapControllers();

app.Run();