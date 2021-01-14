using implementacao.AutoSocorroAbastractFactory.Guinchos;
using implementacao.AutoSocorroAbastractFactory.Shared.Enuns;
using implementacao.AutoSocorroAbastractFactory.Veiculos;

namespace implementacao.AutoSocorroAbastractFactory.AutoSocorros
{
    public class SocorroVeiculoPequenoFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Criar(Porte.Pequeno);
        }

        public override Veiculo CriarVeiculo(string modelo, Porte porte)
        {
            return VeiculoCreator.Criar(modelo, porte);
        }
    }
}
