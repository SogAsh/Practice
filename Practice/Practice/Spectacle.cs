using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice
{
    public class Spectacle
    {
        private readonly List<Action> actions = new List<Action>();

        public Spectacle Say(string message)
        {
            actions.Add(() => Console.WriteLine(message));
            return this;
        }

        public Spectacle Delay(TimeSpan timeSpan)
        {
            actions.Add(() => Thread.Sleep(timeSpan));
            return this;
        }

        public void Play()
        {
            foreach (var action in actions)
            {
                action();
            }
        }

        public Spectacle UntilKeyPressed(Func<Spectacle, Spectacle> inner)
        {
            var innerSpectacle = inner(new Spectacle());
            actions.Add(() =>
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
