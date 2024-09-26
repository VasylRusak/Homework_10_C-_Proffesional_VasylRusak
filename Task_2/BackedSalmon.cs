using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class BackedSalmon : AbstractMeal
    {
        protected override void DoCooking()
        {           
            Console.WriteLine("Baking Salmon in the owen.");
        }

        protected override void DoShoping()
        {
            Console.WriteLine("Going to the Market and buy fresh Salmon.");
        }
    }
}
