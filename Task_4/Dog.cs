using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Dog : Animal
    {
        protected override void MakeSound()
        {
            Console.WriteLine("Гав-гав!");
        }
    }
}
