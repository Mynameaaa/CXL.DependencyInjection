using CXL.DI.API;
using Microsoft.AspNetCore.Diagnostics;

var builder = WebApplication.CreateBuilder(args);


builder.Host.UseServiceProviderFactory<ICXLServiceContainer>(new CXLServiceProviderFactory());
builder.Host.ConfigureContainer<ICXLServiceContainer>(container =>
{

});

builder.Services.AddSingleton<IDeveloperPageExceptionFilter, CXLDeveloperPageExceptionFilter>();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
