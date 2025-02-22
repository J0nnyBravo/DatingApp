using API.Extensions;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddApplicationServices(builder.Configuration);

builder.Services.AddIdentityServices(builder.Configuration);

var app = builder.Build();

//This is the MiddleWare -> Pipeline
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod()
.WithOrigins("http://localhost:4200", "https://localhost:4200"));

app.UseAuthentication(); //Die Reihenfolge der beiden ist entscheident
app.UseAuthorization();

app.MapControllers();

app.Run();
