using OrderManagement.Application.Services;
using OrderManagement.Domain.Services;
using OrderManagement.Infrastructure.Email;
using OrderManagement.Infrastructure.Payment;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<OrderService>();
builder.Services.AddScoped<IPaymentProcessor, PayPalPaymentProcessor>();
builder.Services.AddScoped<INotificationService, EmailNotificationService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
