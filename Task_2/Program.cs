namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prepearing Boiled Eggs");
            AbstractMeal eggs = new BoiledEggs();
            eggs.DoMeal();

            Console.WriteLine("Prepearing Baked Salmon");
            AbstractMeal salmon = new BackedSalmon();
            salmon.DoMeal();

            Console.ReadLine();

        }
    }
}
