using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using ShareLib.SharedExtension;
using ShareLib.SharedMiddlewares;
using UserManagment.api.Middlewares;
using UserManagment.infrastructure.Data;
using UserManagment.infrastructure.Repository;
using UserManagment.service.Interfaces;
using UserManagment.service.usecases;


Env.Load();
var builder = WebApplication.CreateBuilder(args);

var connectionString = Environment.GetEnvironmentVariable("PostgreSqlConnection");
// Add services to the container.
builder.Services.AddControllers();

// Register Repositories and Services for Users
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserService, UserServices>();

// Add authentication service and authorization
builder.Services.AddJwtAuthentication();
builder.Services.AddAuthorization();

builder.Services.AddHttpContextAccessor();
builder.Services.AddSwaggerGen();
// db
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));
// Register Swagger generator (required for ISwaggerProvider)

var app = builder.Build();

//-=-=-=-=-=-=-=-=-=-==-=--==--=-==-=-=-=-=--==-
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// middlewares
app.UseMiddleware<ExceptionMiddleware>();
// Ensure auth order: Authentication then Authorization
app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<RestrictAccessMiddleware>();
app.MapControllers();

app.Run();
