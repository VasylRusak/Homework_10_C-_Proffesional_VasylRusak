using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    abstract class AbstractMeal
    {
        public void DoMeal()
        {
            DoShoping();
            DoCooking();
            DoServing();
        }

        protected abstract void DoShoping();
        protected abstract void DoCooking();

        protected void DoServing()
        {
            Console.WriteLine("Serving dish.");
        }
    }
}
