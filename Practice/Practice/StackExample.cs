using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class StackExample
    {
        //В main нет ссылки на этот метод
        public static void StackExamplesmethod()
        {
            var lines = new[]
            {
                new {command = "push", value = "Привет! Это снова я! Пока!"},
                new {command = "pop", value = "1"},
                new {command = "push", value = "Как твои успехи? Плохо?"},
                new {command = "push", value = "qwertyuiop"},
                new {command = "push", value = "1234567890"},
                new {command = "pop", value = "1"}
            };

            var stack = new Stack<string>();
            foreach (var line in lines)
            {
                if (line.command == "push") //почемуто push складывает не в конец а в начало стека
                    stack.Push(line.value);
                if (line.command == "pop")
                    stack.Pop();
            }

            for (int i = 0; i < stack.ToArray().Length; i++)
            {
                Console.WriteLine(stack.ToArray()[i]);
            }
        }
    }
}
