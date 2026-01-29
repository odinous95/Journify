using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using OcelotApiGateway.Middleware;
using ShareLib.SharedExtension;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot(builder.Configuration);


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy
                .WithOrigins()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

builder.Services.AddControllers();
builder.Logging.AddConsole();
builder.Services.AddJwtAuthentication();


var app = builder.Build();

app.MapGet("/", () => "Hello World from Ocelot Api gateway!");
app.MapControllers();
app.UseMiddleware<InterceptMiddleware>();
app.UseCors("AllowAll");
// Ensure auth order: Authentication then Authorization
app.UseAuthentication();
app.UseAuthorization();

await app.UseOcelot();

app.Run();
