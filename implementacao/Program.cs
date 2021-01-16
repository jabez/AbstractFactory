using implementacao.AutoSocorroAbastractFactory;
using implementacao.ConceptualAbstractFactory;
using System;

namespace implementacao
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o Exemplo:");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - AutoSocorro ");
            Console.WriteLine("2 - ConceptualAbstractFactory ");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    ExecucaoAutoSocorroAbstractFactory.Executar();
                    Console.ReadLine();
                    break;
                case '2':
                    Client.Executar();
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}
