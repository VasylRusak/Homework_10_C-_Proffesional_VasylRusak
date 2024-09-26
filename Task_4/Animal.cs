using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal abstract class Animal
    {
        public void Speak()
        {
            Console.WriteLine("Готуємось до видачі звуку...");
            MakeSound();
            Console.WriteLine("Звук видано.\n");
        }

        protected abstract void MakeSound();
    }
}
