using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Practice.QueuesStacksGenerics
{
    [TestFixture]
    public class ComputeTestClass
    {
        [Test]
        public void ComputeTest()
        {
            Assert.AreEqual(25, ComputeClass.Compute("23+5*"));
        }
    }
    
    public class ComputeClass
    {
        public static int Compute(string str)
        {
            var stack = new Stack<int>();
            foreach (var symbol in str)
            {
                if (symbol <= '9' && symbol >= '0')
                {
                    stack.Push(symbol - '0');
                    continue;
                }
                switch (symbol)
                {
                    case '+':
                        stack.Push(stack.Pop() + stack.Pop());
                        break;
                    case '-':
                        stack.Push(-stack.Pop() + stack.Pop());
                        break;
                    case '*':
                        stack.Push(stack.Pop() * stack.Pop());
                        break;
                    case '/':
                        stack.Push((1 / stack.Pop()) * stack.Pop());
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
            return stack.Pop();
        }
    }
}