using System;

namespace Practice.DataIntegrity
{
    public class Statistics3
    {
        private int successCount;
        private int totalCount;

        public void AccountCase(bool isSuccess)
        {
            totalCount++;
            if (isSuccess) successCount++;
        }
        
        public void Print()
        {
            Console.WriteLine("{0}%", (successCount * 100) / totalCount);
        }
    }

    public static class Program32
    {
        public static void Main33()
        {
            var rnd = new Random();
            var stat = new Statistics3();
            for (int i = 0; i < 1000; i++)
            {
                stat.AccountCase(rnd.Next(3) > 1);
            }

            stat.Print();

            //проблема в том, что никто нам не помешает написать вот так:
            // stat.totalCount = 100;
            // stat.successCount = 146;
            // stat.Print();
        }
    }
}