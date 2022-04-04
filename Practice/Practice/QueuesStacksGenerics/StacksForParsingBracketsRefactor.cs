using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace Practice.QueuesStacksGenerics
{
    public class Program123456
    {
        public static bool Check(string str)
        {
            var stack = new Stack<char>();
            var dict = new Dictionary<char, char>();
            dict['('] = ')';
            dict['['] = ']';
            dict['{'] = '}';
            dict['<'] = '>';

            foreach (var symbol in str)
            {
                if (dict.Keys.Contains(symbol))
                    stack.Push(symbol);
                else if (dict.Values.Contains(symbol))
                {
                    if (stack.Count == 0)
                        return false;
                    var openBracket = stack.Pop();
                    if (dict[openBracket] != symbol)
                        return false;
                }
                else return false;
            }
            if (stack.Count == 0) return true;
            else return false;
            //или return stack.Count == 0;
        }
    }
    
    [TestFixture]
    public class StacksForParsingBracketsRefactor
    {
        [Test]
        public void TooMuchOpenBrackets()
        {
            Assert.AreEqual(false, Program123456.Check("(()"));
        }

        [Test]
        public void TooMuchCloseBrackets()
        {
            Assert.AreEqual(false, Program123456.Check("())"));
        }

        [Test]
        public void BracketsNotMatch()
        {
            Assert.AreEqual(false, Program123456.Check("(]"));
        }

        [Test]
        public void BracketsEmpty()
        {
            Assert.AreEqual(true, Program123456.Check(""));
        }

        [Test]
        public void NotBrackets()
        {
            Assert.AreEqual(false, Program123456.Check("ab"));
        }

        [Test]
        public void RightSequence()
        {
            Assert.AreEqual(true, Program123456.Check("(([])([][]()))"));
        }
        
        [Test]
        public void DifferentBrackets()
        {
            Assert.AreEqual(true, Program123456.Check("(){}[]<>"));
        }
    }
}