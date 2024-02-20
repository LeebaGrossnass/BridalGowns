

using DataAccess;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("BridalGownDB");
//builder.Services.AddDbContext<FoodFactoryContext>(options => options.UseSqlServer(connString));


app.MapGet("/", () => "Hello World!");

app.Run();
