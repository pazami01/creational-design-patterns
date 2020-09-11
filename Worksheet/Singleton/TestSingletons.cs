using System;

namespace QuestionFive
{
    public static class TestSingletons
    {
        public static void Main(string[] args)
        {
            // testing simple singleton
            var singleton1 = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();

            if (singleton1 == singleton2)
            {
                Console.WriteLine($"singleton1 & singleton2 both reference the same object.");
            }
        }
    }
}