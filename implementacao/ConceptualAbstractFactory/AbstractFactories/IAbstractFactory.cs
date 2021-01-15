using implementacao.ConceptualAbstractFactory.ProductsA;

namespace implementacao.ConceptualAbstractFactory.AbstractFactories
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
    }
}
