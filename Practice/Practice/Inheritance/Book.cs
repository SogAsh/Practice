using System;
using System.Collections;

namespace Practice.Inheritance
{
    public class Book : IComparable 
    { 
        public string Title;
        public int Theme;
        
        public int CompareTo(object obj)
        {
            var book1 = new Book();
            var book2 = new Book();
            
            if (book1.Theme.CompareTo(book2.Theme) > 0)
                return 1;
            if (book1.Theme.CompareTo(book2.Theme) == 0)
            {
                if(book1.Title.CompareTo(book2.Title) > 0)
                    return 1;
                if (book1.Title.CompareTo(book2.Title) == 0)
                    return 0;
            }
            
            return -1;
        }

        public static void BookCompare()
        {
            var bookArray = new Book[]
            {
                new Book { Theme = 1, Title = "A" },
            };
            
            var bookArray2 = new Book[]
            {
                new Book { Theme = 1, Title = "C" }
            };


        }
    }
}