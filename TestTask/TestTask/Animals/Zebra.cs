using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.AnimalsTypes;

namespace TestTask.Animals
{
    class Zebra:Herbivore
    {
        public override void Save()
        {
            Console.WriteLine("Я зебра и я спасаюсь");
        }
    }
}
