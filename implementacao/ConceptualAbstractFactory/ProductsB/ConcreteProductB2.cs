using implementacao.ConceptualAbstractFactory.ProductsA;

namespace implementacao.ConceptualAbstractFactory.ProductsB
{
    public class ConcreteProductB2 : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UseFullFunctionA();

            return $"The result of the B2 collaborating with the ({result})";
        }

        public string UsefulFunctionB()
        {
            return "The result of the product B2.";
        }
    }
}
