using System.Text;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Animal dog = new Dog();
            dog.Speak();

            Animal cat = new Cat();
            cat.Speak(); 

            Console.ReadKey();
        }
    }
}
