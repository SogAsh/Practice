using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    abstract class AbstractClass //Уроки C# (C sharp) | #21 - Абстрактные классы, методы и свойства
    {
        //нельзя создать объект абстрактного класса
        //в абстрактном класе могут быть абстрактные, виртуальные и обычные методы и свойства
        public abstract void Print();
        //нужно инициализировать в наследниках

        public virtual void Print2() //не нужно инициализировать в наследниках, но должно быть тело
        {
            
        } 

        public abstract string Name { get; set; }
    }
}
