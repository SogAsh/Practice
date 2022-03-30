using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Practice.QueuesStacksGenerics
{
    [TestFixture]
    public class StacksForParsingBrackets
    {
        [Test]
        public void TooMuchOpenBrackets()
        {
            Assert.AreEqual(false, Program12345.Check("(()"));
        }
        
        [Test]
        public void TooMuchCloseBrackets()
        {
            Assert.AreEqual(false, Program12345.Check("())"));
        }
        
        [Test]
        public void BracketsNotMatch()
        {
            Assert.AreEqual(false, Program12345.Check("(]"));
        }
        
        [Test]
        public void BracketsEmpty()
        {
            Assert.AreEqual(true, Program12345.Check(""));
        }
        
        [Test]
        public void NotBrackets()
        {
            Assert.AreEqual(false, Program12345.Check("ab"));
        }
        
        [Test]
        public void RightSequence()
        {
            Assert.AreEqual(true, Program12345.Check("(([])([][]()))"));
        }
    }

    public class Program12345
    {
        public static bool Check(string str)
        {
            var stack = new Stack<char>();
            foreach (var symbol in str)
            {
                char openBracket;
                switch (symbol)
                {
                    case '(':
                        case '[':
                        stack.Push(symbol);
                        break;
                     case ')':
                         if (stack.Count == 0) 
                             return false;
                         openBracket = stack.Pop();
                         if (openBracket != '(') 
                             return false;
                         break;  
                    case ']':
                        if (stack.Count == 0) 
                            return false;
                        openBracket = stack.Pop();
                        if (openBracket != '[') 
                            return false;
                        break;
                    default:
                        return false;
                }
            }
            if (stack.Count == 0) return true;
            else return false;
            //или return stack.Count == 0;
        }
    }
}