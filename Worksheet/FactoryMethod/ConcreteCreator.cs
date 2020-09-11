namespace QuestionThree
{
    public class ConcreteCreator : Creator
    {
        public override IProduct FactoryMethod(string name)
        {
            return new ConcreteProduct(name);
        }

        public override IProduct FactoryMethod()
        {
            return FactoryMethod("ConcreteProduct");
        }
    }
}