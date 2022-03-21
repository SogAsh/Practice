using System;
using System.Collections.Generic;

namespace Practice.DataIntegrity
{
    public class Transaction
    {
        public int DepartmentId;
        public double Profit;
    }
    
    public class ReportData
    {
        private int departmentsCount;

        // public int GetDapertmentsCount()
        // {
        //     return departmentsCount; 
        // }
        //
        // public void SetDepartmentsCount(int value)
        // {
        //     if (value < 0)
        //         throw new ArgumentException();
        //     departmentsCount = value;
        // }
        
        public int DepartmentsCount
        {
            get { return departmentsCount; }
            set
            {
                if (value < 0) throw new ArgumentException();
                departmentsCount = value;
            }
        }
        
        public List<Transaction> Transactions = new List<Transaction>();
        public void PrintProfits()
        {
            var profits = new double[departmentsCount];
            foreach (var e in Transactions)
                profits[e.DepartmentId] += e.Profit;
            for (int i = 0; i < departmentsCount; i++)
                Console.WriteLine("{0,-10}{1}", i, profits[i]);
        }
    }
    
    public static class UnsafeProgram
    {
        public static void Main2323()
        {
            var report = new ReportData
            {
                // DepartmentsCount = 2,
                Transactions = new List<Transaction>(){
                    new Transaction { DepartmentId=0, Profit=10000 },
                    new Transaction { DepartmentId=1, Profit=20000 },
                    new Transaction { DepartmentId=1, Profit=10000 }
                }
            };
            
            // report.SetDepartmentsCount(2);
            report.DepartmentsCount = 2;
            report.PrintProfits();
            report.DepartmentsCount++;

            //но что, если кто-то напишет так?
            //report.DepartmentsCount = -1;
            //а в этом месте будут тысячи строк кода?
            //report.PrintProfits();
            //отложенная ошибка - это ситуация, в которой 
            //сообщение об ошибке приходит не в том месте, в котором реально
            //было выполнено ошибочное действие.

        }

    }
}