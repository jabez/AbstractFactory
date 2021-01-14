using implementacao.AutoSocorroAbastractFactory.Shared.Enuns;
using implementacao.AutoSocorroAbastractFactory.Veiculos;
using System;

namespace implementacao.AutoSocorroAbastractFactory.Guinchos
{
    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio(Porte porte) : base(porte){}

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo Carro medio - Modelo {veiculo.Modelo}");
        }
    }
}
