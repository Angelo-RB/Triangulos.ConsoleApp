using System;
using System.Collections.Generic;
using System.Text;

namespace Triangulos.ConsoleApp
{
    public class ControladorTriangulo
    {
        public void VerificarTriangulo(int X, int Y, int Z)
        {
            if ((X < Y + Z) && (Y < X + Z) && (Z < X + Y))
            {
                Console.WriteLine();
                Console.Write("Os valores formaram um triângulo!");
                Console.WriteLine();

                if ((X == Y) && (Y == Z))
                {
                    Console.WriteLine();
                    Console.Write("Triângulo Equilátero");

                }
                else if ((X == Y) || (Y == Z) || (X == Z))
                {
                    Console.WriteLine(" ");
                    Console.Write("Triângulo Isósceles");
                }
                else if ((X == Y) || (X == Z) || (Y == Z))
                {
                    Console.WriteLine();
                    Console.Write("Triângulo Escaleno");
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Os valores não formam um triângulo!");
                }
                Console.ReadKey();
            }
        }
    }
}
