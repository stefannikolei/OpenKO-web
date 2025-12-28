using OpenKO.Web;

var builder = WebApplication.CreateBuilder(args);

builder.AddServices();

var app = builder.Build();
app.Configure();


await app.RunAsync();

