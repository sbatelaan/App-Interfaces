using System;

namespace SavingInterface
{
    class TodoList : IDisplayable, IResetable
    {
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }

        public void Display()
        {
            Console.WriteLine("Todos");
            Console.WriteLine("-----");
            foreach (string todo in Todos)
            {
                if (!string.IsNullOrEmpty(todo))
                Console.WriteLine(todo);
                else
                Console.WriteLine("[]");
            }
            Console.WriteLine();
        }

        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }
    }
}