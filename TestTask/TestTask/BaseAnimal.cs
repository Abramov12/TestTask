using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    abstract class BaseAnimal
    {
        public string Name { get; set; }
        private int size;
        public int Size 
        { 
            get => size; 
            set => size= value > 0 ? value : throw new Exception("Размер животного должен быть больше 0"); 
        }
        public abstract void Eat();
    }
}
