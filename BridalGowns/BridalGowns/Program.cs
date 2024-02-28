using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("BridalGownDB");
builder.Services.AddDbContext<BridalContext>(options => options.UseSqlServer(connString));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
