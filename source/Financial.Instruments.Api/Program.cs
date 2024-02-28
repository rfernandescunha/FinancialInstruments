

//a variable to hold configuration
using Financial.Instruments.Api.Configs;


IConfiguration configuration;

var builder = WebApplication.CreateBuilder(args);

configuration = builder.Configuration;


builder.Services.AddDependencyInjectionConfig(configuration);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGenConfig();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
