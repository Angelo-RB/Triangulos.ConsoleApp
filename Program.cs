using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Triangulos.ConsoleApp
{
    class Program
    {
        static void Main(String[] Args)
        {           
            TelaTriangulo telatriangulo = new TelaTriangulo();
            TelaPrincipal telaPrincipal = new TelaPrincipal();

            while (true)
            {
                string opcao = telaPrincipal.ObterOpcao();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

                if (opcao == "1")
                    telatriangulo.InserirDadosTriangulo();

                Console.Clear();
            }
        }
    }

}