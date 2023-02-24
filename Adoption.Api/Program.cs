using Adoption.Api.Filters;
using Adoption.Application.DI;
using Adoption.Infrastructure.DI;
using Adoption.Infrastructure.EF.Options;
using Adoption.Shared.DI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(
    options => options.Filters.Add<ErrorHandlingFilterAttribute>());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration)
    .AddShared();

var section = builder.Configuration.GetSection("Logging");

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
