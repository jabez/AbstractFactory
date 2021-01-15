using implementacao.ConceptualAbstractFactory.ProductsA;

namespace implementacao.ConceptualAbstractFactory.AbstractFactories
{
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }
    }
}
