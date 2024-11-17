using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VerifySiretNumber.Services;
using VerifySiretNumber;

var builder = Host.CreateApplicationBuilder(args);

//Registers a Scoped service to verify Siret number.
builder.Services.AddScoped<IVerifySiret, VerifySiret>();

//Registers a Scoped service to start the application.
builder.Services.AddScoped<Start>();

var host = builder.Build();
var app = host.Services.GetRequiredService<Start>();

app.Run();
