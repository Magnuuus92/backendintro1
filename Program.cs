using Microsoft.JSInterop.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var todoList = new TodoList();

// read todos
app.MapGet("/todo", () =>
{
    return "returning todos ";
});


app.MapPost("/todo", () =>
{
    var NewTodoItem = new TodoItem();


    return NewTodoItem;
    

});




app.Run();