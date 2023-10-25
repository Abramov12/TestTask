using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Interfaces;

namespace TestTask.AnimalsTypes
{
    class MeatEater : BaseAnimal, IHunt
    {
        public string HuntTime { get; set; } = "Охочусь в любое время";
        public override void Eat()
        {
            Console.WriteLine("Я плотоядное и ем плоть");
        }
        public virtual void Hunt()
        {
            Console.WriteLine("Я ем плоть, поэтому я охочусь");
        }

    }
}
