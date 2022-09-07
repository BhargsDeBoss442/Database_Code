namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            var todoList = new List<Todo>();

            while(true)
            {

            Console.WriteLine("Please enter the number of the activity");
            Console.WriteLine("1 Enter a new Todo");
            Console.WriteLine("2 Mark Todo as done");
            Console.WriteLine("3 Delete todo");
            Console.WriteLine("4 Show Todos");

            var sampleTodo = new Todo
            {
                IsDone = true,
                TaskText = "This is a sample todo",

            };
            todoList.Add(sampleTodo);

            int inputOption;
            int.TryParse(Console.ReadLine(), out inputOption);

            switch (inputOption)
            {
                case 1:

                    Console.WriteLine("Please enter a new Todo");
                    var todoString = Console.ReadLine();
                    var newTodo = new Todo
                    {
                        IsDone = false,
                        TaskText = todoString!,
                    };
                    todoList.Add(newTodo);

                    break;

                case 2:
                    Console.WriteLine("REMINDER: Have you todos before you delete at them");
        
                    Console.WriteLine("Would you like to mark a Todo as complete");
                    var name_of_todo1 = Console.ReadLine();
                    foreach(var todo in todoList)
                    {
                        if(name_of_todo1 == todo.TaskText)
                        {
                            todo.IsDone = true;
                        }
                    }

                    



                    break;
                case 3:
                    Console.WriteLine("REMINDER: Have you todos before you delete at them");
        
                    Console.WriteLine("Would you like to delete a Todo");
                    var name_of_todo = Console.ReadLine();
                    for(var i = 0; i < todoList.Count; i++)
                    {
                        var new_todo = todoList[i];
                        if(name_of_todo == new_todo.TaskText)
                        {
                            todoList.Remove(new_todo);
                        }
                    }

                    break;
                case 4:
                    foreach(var todo in todoList)
                    {
                        Console.WriteLine(todo.TaskText + " : " + (todo.IsDone ? "Completed" : "Not Completed "));
                    }
                    break;
                default:
                    break;
                }
            }
        }
    }
}