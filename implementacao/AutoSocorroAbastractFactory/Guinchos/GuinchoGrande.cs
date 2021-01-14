using implementacao.AutoSocorroAbastractFactory.Shared.Enuns;
using implementacao.AutoSocorroAbastractFactory.Veiculos;
using System;

namespace implementacao.AutoSocorroAbastractFactory.Guinchos
{
    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte){}

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo Carro grande - Modelo {veiculo.Modelo}");
        }
    }
}
