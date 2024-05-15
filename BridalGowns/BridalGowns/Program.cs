using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using DAL.Implementation;
using DAL.Models;
using DAL.API;
using DAL;
using BL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
//builder.Services.AddScoped<IClientRepo, ClientRepo>();
//builder.Services.AddScoped<IGownRepo, GownRepo>();
//builder.Services.AddScoped<ICrownRepo, CrownRepo>();
//builder.Services.AddScoped<IMeetingRepo, MeetingRepo>();
//builder.Services.AddScoped<IOrderRepo, OrderRepo>();
//builder.Services.AddScoped<ISceduleRepo, SceduleRepo>();

//DBActions actions = new DBActions(builder.Configuration);
//var connString = actions.GetConnectionString("BridalGownDB");
//builder.Services.AddDbContext<BridalContext>(options => options.UseSqlServer(connString));
builder.Services.AddScoped<BLManager>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();
