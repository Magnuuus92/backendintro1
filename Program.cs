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
    var NewTodoItem = new TodoItem("this is a task", DateTime.Today);


    return NewTodoItem;
    

});




app.Run();