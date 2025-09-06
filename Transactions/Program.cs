using System.Reflection;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Transactions.Infrastructure.Services;
using Transactions.Intrastructure.Middlewares;
using Transactions.Intrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Register MediatR
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

// Add lifecycle
builder.Services.AddScoped<ITransactionService, TransactionService>();

// Tldr; you cannot use inmemory database with retry strategy
builder.Services.AddDbContext<DummyContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DummyDatabase")
    )
    .EnableRetryOnFailure(
        maxRetryCount: 5,
        maxRetryDelay: TimeSpan.FromSeconds(30),
        errorNumbersToAdd: null
    )
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Add the TransactionMiddleware
app.UseMiddleware<TransactionMiddleware>();

app.MapControllers();

app.Run();
