using Microsoft.JSInterop.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/Ingenting", () =>
{
    return $"Ingenting ";
});
app.MapGet("/greetings", (string name) =>
{
    if (name == "Magnus")
    {
        return $"Hei MAGNU$";
    }
    else
    {
        return $"Greetings: {name}";

    }
});

app.MapPost("/post", (string body) =>
{
    return $"Post; Path: / {body}";

});


app.MapPut("/", (string body) =>
{
    return $"Put; Path: / {body}";
});

app.MapDelete("/delete", (string body) =>
{
    return $"Delete; Path: / {body}";
});

app.Run();