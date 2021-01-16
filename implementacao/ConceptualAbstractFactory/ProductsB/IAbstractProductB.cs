using implementacao.ConceptualAbstractFactory.ProductsA;

namespace implementacao.ConceptualAbstractFactory.ProductsB
{
    public interface IAbstractProductB
    {
        string UsefulFunctionB();
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
