using implementacao.AutoSocorroAbastractFactory.Shared.Enuns;
using implementacao.AutoSocorroAbastractFactory.Veiculos;

namespace implementacao.AutoSocorroAbastractFactory.Guinchos
{
    public abstract class Guincho
    {
        public Porte Porte { get; set; }

        protected Guincho(Porte porte)
        {
            Porte = porte;
        }

        public abstract void Socorrer(Veiculo veiculo);
    }
}
