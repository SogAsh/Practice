using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Practice
{
    class PasswordStrengthValidator_Test
    {
        const int minLength = 6;

        public static void Validate(string password)
        {
            if (password == null || password.Length < minLength)
            {
                throw new ArgumentException($"Password must be at least {minLength} symbols long");
            }

            if (!password.Any(char.IsUpper))
            {
                throw new ArgumentException("Password must contain an uppercase letter");
            }

            if (!password.Any(char.IsDigit))
            {
                throw new ArgumentException("Password must contain a digit");
            }

            Console.WriteLine("Password is OK");
        }

        [TestCase("Sh0rt")]
        [TestCase("Яsh0rt")]
        [TestCase("n0uppercase")]
        [TestCase("noDigits")]
        [TestCase("")]
        [TestCase(null)]
        [TestCase("Success1")]
        [TestCase("SUCCESS2")]
        public static void Val(string password)
        {
            Assert.Throws<ArgumentException>(
                () => Validate(password));

            Console.WriteLine(password);
        }
    }
}
