using implementacao.AutoSocorroAbastractFactory.Guinchos;
using implementacao.AutoSocorroAbastractFactory.Shared.Enuns;
using implementacao.AutoSocorroAbastractFactory.Veiculos;
using System;

namespace implementacao.AutoSocorroAbastractFactory.AutoSocorros
{
    public class AutoSocorro
    {
        private readonly Veiculo _veiculo;
        private readonly Guincho _guincho;

        public AutoSocorro(AutoSocorroFactory factory, Veiculo veiculo)
        {
            _veiculo = factory.CriarVeiculo(veiculo.Modelo, veiculo.Porte);
            _guincho = factory.CriarGuincho();
        }

        public void RealizarAtendimento()
        {
            _guincho.Socorrer(_veiculo);
        }

        public static AutoSocorro CriarAutoSocorro(Veiculo veiculo)
        {
            return veiculo.Porte switch
            {
                Porte.Pequeno => new AutoSocorro(new SocorroVeiculoPequenoFactory(), veiculo),
                Porte.Medio => new AutoSocorro(new SocorroVeiculoMedioFactory(), veiculo),
                Porte.Grande => new AutoSocorro(new SocorroVeiculoGrandeFactory(), veiculo),
                _ => throw new ApplicationException("Não foi possível identificar o veículo"),
            };
        }
    }
}
