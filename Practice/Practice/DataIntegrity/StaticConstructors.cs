using System;

namespace Practice.DataIntegrity
{
    public class StaticConstructors
    {
        public static readonly DateTime Readonly;
        public readonly int Number;
        
        //Статические конструкторы всегда без параметров
        static StaticConstructors()
        {
            Readonly = DateTime.Now;
        }
        
        //это динамический конструктор
        public StaticConstructors()
        {
            Number = 3;
        }
    }
}