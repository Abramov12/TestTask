using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.AnimalsTypes;

namespace TestTask.Animals
{
    class Cat : Omnivore
    {
        public override void Hunt()
        {
            Console.WriteLine("Я кот и охочусь на птиц");
        }
        public override void Save()
        {
            Console.WriteLine("Я кот и спасаюсь от собаки");
        }
        public override void Eat()
        {
            Console.WriteLine("Я кот и ем птиц и траву");
        }
    }
}
