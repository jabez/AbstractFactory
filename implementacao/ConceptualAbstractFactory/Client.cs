using implementacao.ConceptualAbstractFactory.AbstractFactories;
using System;

namespace implementacao.ConceptualAbstractFactory
{
    public class Client
    {
        public static void Executar()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();
        }

        public static void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            //var productB = factory.CreateProductB();

            //Console.WriteLine(productB.UsefulFunctionB());
            //Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
