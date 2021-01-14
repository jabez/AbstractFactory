using implementacao.AutoSocorroAbastractFactory.Shared.Enuns;
using System;

namespace implementacao.AutoSocorroAbastractFactory.Veiculos
{
    public class VeiculoCreator
    {
        public static Veiculo Criar(string modelo, Porte porte)
        {
            return porte switch
            {
                Porte.Pequeno => new VeiculoPequeno(modelo, porte),
                Porte.Medio => new VeiculoMedio(modelo, porte),
                Porte.Grande => new VeiculoGrande(modelo, porte),
                _ => throw new ApplicationException("Porte de veiculo desconhecido."),
            };
        }
    }
}
