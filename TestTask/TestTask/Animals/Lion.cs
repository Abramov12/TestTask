using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.AnimalsTypes;

namespace TestTask.Animals
{
    class Lion : MeatEater
    {
        public override void Hunt()
        {
            Console.WriteLine("Я лев и охочусь");
        }
    }
}
