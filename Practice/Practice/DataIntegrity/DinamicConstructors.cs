using System;

namespace Practice.DataIntegrity
{
    public class TournirInfo0
    {
        public readonly int TeamsCount;
        public readonly string[] TeamsNames;
        public readonly double[,] Scores;
        
        // public readonly int TeamsCount { get; private set; }
        // public readonly string[] TeamsNames { get; private set; }
        // public readonly double[,] Scores { get; private set; }

        public TournirInfo0 (int teamsCount) //конструктор 1
        {
            TeamsCount = teamsCount;
            TeamsNames = new string[teamsCount];
            Scores = new double[teamsCount, teamsCount];
        }
        
        public TournirInfo0 (params string[] Names) //конструктор 2
        {
            TeamsCount = Names.Length;
            TeamsNames = Names;
            Scores = new double[TeamsCount, TeamsCount];
        }
        
        public TournirInfo0() : this(5) //конструктор 3 по умолчанию, который вызывает конструктор 1, потому что передаваемое значение = 5
                                                //т.е. мы ищем конструктор в который передается int
        {
        }
    }

    public class Programs123
    {
        public static void Maintest1()
        {
            // var tournirinfo = new TournirInfo0(5);
            // tournirinfo.TeamsNames[2] = "Test";
            //
            // tournirinfo = new TournirInfo0("Team1", "Team1");
            var tournirinfo1 = new TournirInfo0();
        }
    }
}