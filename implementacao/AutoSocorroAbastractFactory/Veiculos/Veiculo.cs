using implementacao.AutoSocorroAbastractFactory.Shared.Enuns;

namespace implementacao.AutoSocorroAbastractFactory.Veiculos
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public Porte Porte { get; set; }

        protected Veiculo(string modelo, Porte porte)
        {
            Modelo = modelo;
            Porte = porte;
        }
    }
}