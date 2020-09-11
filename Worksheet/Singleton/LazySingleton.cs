namespace QuestionFive
{
    public class LazySingleton
    {
        private static LazySingleton _instance;

        private LazySingleton() { }

        public static LazySingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LazySingleton();
            }

            return _instance;
        }
    }
}