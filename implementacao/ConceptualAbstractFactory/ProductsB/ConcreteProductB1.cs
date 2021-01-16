using implementacao.ConceptualAbstractFactory.ProductsA;

namespace implementacao.ConceptualAbstractFactory.ProductsB
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UseFullFunctionA();

            return $"The result of the B1 collaborating with the ({result})";
        }

        public string UsefulFunctionB()
        {
            return "The result of the product B1.";
        }
    }
}
