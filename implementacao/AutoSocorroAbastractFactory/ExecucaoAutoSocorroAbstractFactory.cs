using implementacao.AutoSocorroAbastractFactory.AutoSocorros;
using implementacao.AutoSocorroAbastractFactory.Shared.Enuns;
using implementacao.AutoSocorroAbastractFactory.Veiculos;
using System.Collections.Generic;

namespace implementacao.AutoSocorroAbastractFactory
{
    public class ExecucaoAutoSocorroAbstractFactory
    {
        public static void Executar()
        {
            var veiculosSocorro = new List<Veiculo>
            {
                VeiculoCreator.Criar("Celta", Porte.Pequeno),
                VeiculoCreator.Criar("Jetta", Porte.Medio),
                VeiculoCreator.Criar("BMW", Porte.Grande),
            };

            veiculosSocorro.ForEach(v => AutoSocorro.CriarAutoSocorro(v).RealizarAtendimento());
        }
    }
}
