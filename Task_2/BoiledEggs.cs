using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class BoiledEggs : AbstractMeal
    {
        protected override void DoShoping()
        {
            Console.WriteLine("Go to shop for the eggs.");
        }

        protected override void DoCooking()
        {
            Console.WriteLine("Boiling eggs.");
        }

    }
}
