using implementacao.AutoSocorroAbastractFactory.Shared.Enuns;
using implementacao.AutoSocorroAbastractFactory.Veiculos;
using System;

namespace implementacao.AutoSocorroAbastractFactory.Guinchos
{
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo Carro Pequeno - Modelo {veiculo.Modelo}");
        }
    }
}
