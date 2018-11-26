using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsNSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>()
            {
                new Todo { Description = "Task 1", EstimatedHours = 6, Status = Status.Completed },
                new Todo { Description = "Task 2", EstimatedHours = 2, Status = Status.InProgress },
                new Todo { Description = "Task 3", EstimatedHours = 8, Status = Status.NotStarted },
                new Todo { Description = "Task 4", EstimatedHours = 12, Status = Status.Deleted },
                new Todo { Description = "Task 5", EstimatedHours = 6, Status = Status.InProgress },
                new Todo { Description = "Task 6", EstimatedHours = 2, Status = Status.NotStarted },
                new Todo { Description = "Task 7", EstimatedHours = 14, Status = Status.NotStarted },
                new Todo { Description = "Task 8", EstimatedHours = 8, Status = Status.Completed },
                new Todo { Description = "Task 9", EstimatedHours = 8, Status = Status.InProgress },
                new Todo { Description = "Task 10", EstimatedHours = 8, Status = Status.Completed },
                new Todo { Description = "Task 11", EstimatedHours = 4, Status = Status.NotStarted },
                new Todo { Description = "Task 12", EstimatedHours = 10, Status = Status.Completed },
                new Todo { Description = "Task 13", EstimatedHours = 12, Status = Status.Deleted },
                new Todo { Description = "Task 14", EstimatedHours = 6, Status = Status.Completed }
            };

            //Console.ForegroundColor = ConsoleColor.Blue; // Cool, uses Enum for colors


            PrintAssessment(todos);


            Console.ReadLine();

        }

        private static void PrintAssessment(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status) // switch tab-tab todo.Status Enter-Enter
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("[{2}] {0}({1})", todo.Description, todo.EstimatedHours, todo.Status);
            }
        }
    }

    class Todo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
    }

    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }
}
