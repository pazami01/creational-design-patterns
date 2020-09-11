namespace QuestionThree
{
    public interface ICreator
    {
        public IProduct FactoryMethod();
        public string ABusinessOperation(int type);
    }
}