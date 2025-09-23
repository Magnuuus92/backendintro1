class TodoItem
{
//properties
public string Description;
public bool IsComplete;
public DateTime Deadline;
public DateTime CreatedAt;

//constructor /beskirvelse av hvordan man lager denne klassen.
public TodoItem(string Description DateTime Deadline){
    IsComplete = false;
    CreatedAt = DateTime.Now;
    Description = Description;
    Deadline = deadline;
}
}