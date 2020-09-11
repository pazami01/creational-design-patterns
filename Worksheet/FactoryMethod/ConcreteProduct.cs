namespace QuestionThree
{
    public class ConcreteProduct : IProduct
    {
        public string Name { get; private set; }

        public ConcreteProduct(string name)
        {
            Name = name;
        }
    }
}