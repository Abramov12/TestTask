using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Interfaces;

namespace TestTask.AnimalsTypes
{
    class Herbivore : BaseAnimal, ISaveFromPredators
    {
        public override void Eat()
        {
            Console.WriteLine("Я травоядное и ем траву");
        }
        public virtual void Save()
        {
            Console.WriteLine("Я ем траву, поэтому я спасаюсь");
        }
    }
}
