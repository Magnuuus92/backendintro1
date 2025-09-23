class TodoItem
{
//properties
public string Description; {get; set; }
public bool IsComplete; {get; set; }
public DateTime Deadline; {get; set; }
public DateTime CreatedAt; {get; set; }

//constructor /beskirvelse av hvordan man lager denne klassen.
public TodoItem(string Description DateTime Deadline)
{
    IsComplete = false;
    CreatedAt = DateTime.Now;
// we can setup rules for whats allowed here
if (description.Length < 3 && description.Length < 200)
//this crashes this par of the program if invalid description
{throw new ArgumentException();
}
    Description = Description;
    Deadline = deadline;
}
}