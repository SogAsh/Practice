using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice
{
    public static class NewSpectacleExtensions
    {
        public static NewSpectacle TypeText(this NewSpectacle newSpectacle, string message)
        {
            newSpectacle.Schedule(() =>
            {
                foreach (var ch in message)
                {
                    Console.Write(ch);
                    Thread.Sleep(50);
                }
                Console.WriteLine();
            });
            return newSpectacle;
        }
    }

    public class NewSpectacle
    {
        private readonly List<Action> actions = new List<Action>();

        public void Schedule(Action action)
        {
            actions.Add(action);
        }
        public NewSpectacle Say(string message)
        {
            Schedule(() => Console.WriteLine(message));
            return this;
        }

        public NewSpectacle Delay(TimeSpan timeSpan)
        {
            Schedule(() => Thread.Sleep(timeSpan));
            return this;
        }

        public void Play()
        {
            foreach (var action in actions)
            {
                action();
            }
        }

        public NewSpectacle UntilKeyPressed(Func<NewSpectacle, NewSpectacle> inner)
        {
            var innerSpectacle = inner(new NewSpectacle());
            Schedule(() =>
            {
                while (!Console.KeyAvailable)
                {
                    innerSpectacle.Play();
                }

                Console.ReadKey(true);
            });

            return this;
        }
    }

    
}
