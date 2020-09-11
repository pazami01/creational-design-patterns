using System;

namespace QuestionThree
{
    public static class Driver
    {
        public static void Main(string[] args)
        {
            string separator = "-------------------------------------------";

            ICreator creator = new Creator();
            Console.WriteLine(creator.ABusinessOperation(0));

            Console.WriteLine();

            Console.WriteLine(creator.ABusinessOperation(1));

            Console.WriteLine();

            Console.WriteLine(creator.ABusinessOperation(2));

            Console.WriteLine(separator);

            ICreator concreteCreator = new ConcreteCreator();
            Console.WriteLine(concreteCreator.ABusinessOperation(0));

            Console.WriteLine();

            Console.WriteLine(concreteCreator.ABusinessOperation(1));

            Console.WriteLine();

            Console.WriteLine(concreteCreator.ABusinessOperation(2));
        }
    }
}