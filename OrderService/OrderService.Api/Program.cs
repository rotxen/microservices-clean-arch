using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using OrderService.Infrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("GatewayPolicy", policy =>
    {
        policy.WithOrigins("https://localhost:6000")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Services
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// JWT
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateAudience = false,
            ValidateIssuer = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = false
        };
    });

builder.Services.AddAuthorization();

var app = builder.Build();

app.UseMiddleware<OrderService.Api.Middlewares.ApiGatewayRestrictionMiddleware>();

app.UseCors("GatewayPolicy");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();

app.Run();
