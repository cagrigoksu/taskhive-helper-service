using Microsoft.EntityFrameworkCore;
using TaskHive_HelperService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = builder.Configuration;

// ----- Azure Production -----
//var azureConnectionString = Environment.GetEnvironmentVariable("AzureSQLConnection");

//builder.Services.AddDbContext<TaskHive_UserService.AppDbContext>( options =>
//    options.UseSqlServer(azureConnectionString));

// ----- Local Development -----
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("LocalSQLConnection")));

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
