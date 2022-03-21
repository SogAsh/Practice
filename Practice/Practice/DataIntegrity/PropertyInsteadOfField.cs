using System;

namespace Practice.DataIntegrity
{
    public class PropertyInsteadOfField
    {
        public static void Check1()
        {
            var book = new Books1();
            book.Title = "Structure and interpretation of computer programs";
            Console.WriteLine(book.Title);
        }
    }
    
    public class Books1
    {
        public string Title { get; set; }
    }
}