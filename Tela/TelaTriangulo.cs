using System;
using System.Collections.Generic;
using System.Text;

namespace Triangulos.ConsoleApp
{
    public class TelaTriangulo
    {
        Triangulo triangulo = new Triangulo();

        public void InserirDadosTriangulo()
        {
            Console.WriteLine();
            Console.Write("Informe o lado X: ");
            triangulo.X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Informe o lado Y: ");
            triangulo.Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Informe o lado Z: ");
            triangulo.Z = Convert.ToInt32(Console.ReadLine());
        }
    }
}
