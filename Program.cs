using Microsoft.JSInterop.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// read todos
app.MapGet("/todo", () =>
{
    return "returning todos ";
});


app.MapPost("/todo", () =>
{
    return $"Post; Path: / ";

});




app.Run();