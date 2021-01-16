using implementacao.ConceptualAbstractFactory.ProductsA;
using implementacao.ConceptualAbstractFactory.ProductsB;

namespace implementacao.ConceptualAbstractFactory.AbstractFactories
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}
