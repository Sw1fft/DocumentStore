using DocumentStore.Application.Repositories;
using DocumentStore.Application.Services;
using DocumentStore.Application.Mapper;
using DocumentStore.Domain.Interfaces;
using DocumentStore.Application.Auth;
using Microsoft.EntityFrameworkCore;
using DocumentStore.API.Extensions;
using DocumentStore.API.Mapper;
using DocumentStore.Data;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddApiAuthentification(configuration);

builder.Services.AddScoped<IDocumentService, DocumentService>();
builder.Services.AddScoped<IPasswordService, PasswordService>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IDocumentRepository, DocumentRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IJwtProvider, JwtProvider>();
builder.Services.Configure<JwtOptions>(configuration.GetSection(nameof(JwtOptions)));

builder.Services.AddDbContext<DocumentStoreDbContext>(options =>
{
    options.UseNpgsql(configuration.GetConnectionString(nameof(DocumentStoreDbContext)));
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(PofileMapper));
builder.Services.AddAutoMapper(typeof(MapperProfile));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
