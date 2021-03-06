namespace QuestionFive
{
    public class Singleton
    {
        private static Singleton _instance = new Singleton();

        private Singleton() { }

        public static Singleton GetInstance()
        {
            return _instance;
        }
    }
}