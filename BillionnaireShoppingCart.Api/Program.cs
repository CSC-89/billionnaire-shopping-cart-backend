using BillionnaireShoppingCart.Api.Db;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var billionnaireDb = new BillionnairesDb();
var productsDb = new ProductsDb();

builder.Services.AddSingleton(billionnaireDb);
builder.Services.AddSingleton(productsDb);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors(policy =>
{
    policy.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();  //set the allowed origin
});

app.UseAuthorization();

app.MapControllers();

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
var url = $"http://0.0.0.0:{port}";

app.Run(url);
