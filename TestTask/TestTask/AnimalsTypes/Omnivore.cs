using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Interfaces;

namespace TestTask.AnimalsTypes
{
    class Omnivore : BaseAnimal, IHunt, ISaveFromPredators
    {
        public string HuntTime { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Я всеядное и ем и плоть и траву");
        }
        public virtual void Hunt()
        {
            Console.WriteLine("Я всеядное, поэтому иногда охочусь");
        }
        public virtual void Save()
        {
            Console.WriteLine("Я всеядное, поэтому иногда спасаюсь");
        }
    }
}
