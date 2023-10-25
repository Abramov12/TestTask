using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TestTask.Animals;
using TestTask.AnimalsTypes;
using TestTask.Interfaces;

namespace TestTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Создадим экземляры классов для наглядного просмотра реализации принципов ООП
            //Arrange
            var meatEater = new MeatEater();
            var herbivore = new Herbivore();
            var omnivore = new Omnivore();

            var cat = new Cat()
            {
                Name = "Cat",
                HuntTime = "День",
                Size=3
            };
            var lion = new Lion();
            var zebra = new Zebra();

            var list = new List<BaseAnimal>() { meatEater, herbivore, omnivore, cat, lion, zebra };
            //Act
            Console.WriteLine("Пример динамического полиморфизма");

            foreach(var animal in list)
            {
                Console.WriteLine();
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine();
                animal.Eat();
                if(animal is IHunt)
                {
                    IHunt hunter = (IHunt)animal;
                    hunter.Hunt();
                }
                if(animal is ISaveFromPredators)
                {
                    ISaveFromPredators victim = (ISaveFromPredators)animal;
                    victim.Save();
                }
            }
        }
    }
}
