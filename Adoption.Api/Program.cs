using Adoption.Api.Filters;
using Adoption.Application;
using Adoption.Auth.DI;
using Adoption.Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Adoption.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(
    options => options.Filters.Add<ErrorHandlingFilterAttribute>());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration)
    .AddShared()
    .AddAuth();

//builder.Services
//    .AddAuthentication("MyCookieAuth")
//    .AddCookie("MyCookieAuth",options =>
//    options.AccessDeniedPath = "/api/auth/AccessDenied");

builder.Services.AddMediatR(cfg => {
    cfg.RegisterServicesFromAssembly(typeof(ApplicationAssemblyReference).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(InfrastructureAssemblyReference).Assembly);
});

builder.Services
    .AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;

    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("super-secret-key")),
            ValidateLifetime = true,
            ValidateAudience = false,
            ValidateIssuer = false,
            ClockSkew = TimeSpan.Zero
        };
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("MustBelongToHR",
        policy => policy.RequireClaim("Department", "HR"));
});

var section = builder.Configuration.GetSection("Logging");

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
