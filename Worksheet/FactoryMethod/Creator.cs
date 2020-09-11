using System;

namespace QuestionThree
{
    public class Creator : ICreator
    {
        // Returns a default product
        public virtual IProduct FactoryMethod(string name)
        {
            return new ConcreteProduct(name);
        }


        // Returns a default product
        public virtual IProduct FactoryMethod()
        {
            return FactoryMethod("DefaultConcreteProduct");
        }

        public string ABusinessOperation(int type = 0)
        {
            IProduct product;

            if (type == 1)
            {
                product = FactoryMethod("Light");
            }
            else if (type == 2)
            {
                product = FactoryMethod("Heavy");
            }
            else
            {
                product = FactoryMethod();
            }

            return $"This is a ABusinessOperation using the product: {product.Name}";
        }
    }
}