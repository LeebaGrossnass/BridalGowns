using DAL;
using DAL.Models;
using DAL.Implementation;
using DAL.Models;
using DAL.API;
using DAL;
using BL;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();

var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy", builder =>
    {
        builder.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:3000");
    });
});

DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("BridalGownDB");
builder.Services.AddDbContext<BridalContext>(options => options.UseSqlServer(connString));
//builder.Services.AddScoped<BLManager>();
builder.Services.AddScoped(b => new BLManager(connString));

var app = builder.Build();
app.UseCors("CORSPolicy");
app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();








