using implementacao.AutoSocorroAbastractFactory.Guinchos;
using implementacao.AutoSocorroAbastractFactory.Shared.Enuns;
using implementacao.AutoSocorroAbastractFactory.Veiculos;

namespace implementacao.AutoSocorroAbastractFactory.AutoSocorros
{
    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuincho();
        public abstract Veiculo CriarVeiculo(string modelo, Porte porte);
    }
}