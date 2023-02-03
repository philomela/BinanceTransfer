using System.Reflection;
using BinanceTransfer.Application;
using BinanceTransfer.Application.Commands.CreateTransaction;
using BinanceTransfer.Application.Common.Mappings;
using BinanceTransfer.Application.Queries.GetCard;
using BinanceTransfer.Domain.Interfaces;
using BinanceTransfer.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddAutoMapper(cfg 
    =>
{
    cfg.AddProfile(new AssemblyMappigProfile(Assembly.GetExecutingAssembly()));
    cfg.AddProfile(new AssemblyMappigProfile(typeof(IMapper<>).Assembly));
});

var app = builder.Build();

//app.UseCors();
//app.UseHttpsRedirection();

app.MapPost("/createTransaction", async ([FromServices] IMediator mediator) => 
    await mediator.Send(new CreateTransactionCommand(DateTime.Now, "BinanceTransaction1")));

app.MapGet("/getCard", async ([FromServices] IMediator mediator) =>
    await mediator.Send(new GetCardQuery()));

app.Run();