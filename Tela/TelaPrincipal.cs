using System;
using System.Collections.Generic;
using System.Text;

namespace Triangulos.ConsoleApp
{
    public class TelaPrincipal
    {
        TelaTriangulo telatriangulo = new TelaTriangulo();

        public void ObterOpcao()
        {
            string opcao;
            do
            {
                Console.Clear();

                Console.WriteLine("======================Menu=====================");
                Console.WriteLine("=                                             =");
                Console.WriteLine("=                   Digite:                   =");
                Console.WriteLine("=                                             =");
                Console.WriteLine("=         1 para os Dados do Triangulo        =");    
                Console.WriteLine("=                                             =");
                Console.WriteLine("=                S para Sair                  =");
                Console.WriteLine("=                                             =");
                Console.WriteLine("===============================================");

                opcao = Console.ReadLine();

                if (opcao == "1")
                    telatriangulo.InserirDadosTriangulo();

                else if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

            } while (OpcaoInvalida(opcao));

        }
        private bool OpcaoInvalida(string opcao)
        {
            if (opcao != "1" && opcao != "S" && opcao != "s")
            {
                Console.WriteLine("Opção inválida");
                Console.ReadLine();
                return true;
            }
            else
                return false;
        }

    }
}
