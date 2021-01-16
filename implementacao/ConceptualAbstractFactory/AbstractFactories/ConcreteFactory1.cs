﻿using implementacao.ConceptualAbstractFactory.ProductsA;
using implementacao.ConceptualAbstractFactory.ProductsB;

namespace implementacao.ConceptualAbstractFactory.AbstractFactories
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
