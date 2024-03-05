using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
<<<<<<< HEAD
=======

>>>>>>> aa828caf716806d70ffc9a66d99ce8e700724458


DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("BridalGownDB");
builder.Services.AddDbContext<BridalContext>(options => options.UseSqlServer(connString));
var app = builder.Build();
<<<<<<< HEAD

=======
>>>>>>> aa828caf716806d70ffc9a66d99ce8e700724458

app.MapGet("/", () => "Hello World!");

app.Run();
