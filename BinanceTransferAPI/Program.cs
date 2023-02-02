using BinanceTransfer.Application;
using BinanceTransfer.Application.Commands.CreateTransaction;
using BinanceTransfer.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();

var app = builder.Build();

//app.UseCors();
//app.UseHttpsRedirection();

app.MapPost("/createTransaction", async ([FromServices] IMediator mediator) => 
    await mediator.Send(new CreateTransactionCommand(DateTime.Now, "BinanceTransaction1")));

app.Run();