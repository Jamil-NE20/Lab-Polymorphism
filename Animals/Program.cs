using System;

namespace Animals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal cat = new Cat("Peter", "Whiskas");
            Animal dog = new Dog("Gunnar", "Meat");

            Console.WriteLine("\nOutput:\n");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());


            Console.WriteLine("Any key to Quit!");
            Console.ReadLine();
        }
    }
}
