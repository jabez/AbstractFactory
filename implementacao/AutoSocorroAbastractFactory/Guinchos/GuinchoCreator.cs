using implementacao.AutoSocorroAbastractFactory.Shared.Enuns;
using System;

namespace implementacao.AutoSocorroAbastractFactory.Guinchos
{
    public class GuinchoCreator
    {
        public static Guincho Criar(Porte porte)
        {
            return porte switch
            {
                Porte.Pequeno => new GuinchoPequeno(porte),
                Porte.Medio => new GuinchoMedio(porte),
                Porte.Grande => new GuinchoGrande(porte),
                _ => throw new ApplicationException("Porte de Guincho desconhecido."),
            };
        }
    }
}
