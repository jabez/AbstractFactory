using implementacao.ConceptualAbstractFactory.ProductsA;
using implementacao.ConceptualAbstractFactory.ProductsB;

namespace implementacao.ConceptualAbstractFactory.AbstractFactories
{
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
