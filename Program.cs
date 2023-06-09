using Banking.Model;
using Banking.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<BankService>();
builder.Services.AddTransient<BankLoanService>();
builder.Services.AddTransient<CibilService>();
builder.Services.AddTransient<CustomerService>();
builder.Services.AddTransient<LoanDetailsService>();
builder.Services.AddDbContext<BankingDbContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("DC")));
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
