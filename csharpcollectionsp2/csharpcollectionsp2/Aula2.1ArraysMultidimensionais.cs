using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcollectionsp2
{
    class Aula2
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 3;
            string[,] resultados = new string[x, y];
            //{
            //    { "Alemanha","Espanha","Itália" },
            //    { "Argentina","Holanda","França"},
            //    { "Holanda","Alemanha","Alemanha" }
            //};
            resultados[0, 0] = "Alemanha";
            resultados[1, 0] = "Espanha";
            resultados[2, 0] = "Itália";
            resultados[0, 1] = "Argentina";
            resultados[1, 1] = "Holanda";
            resultados[2, 1] = "França";
            resultados[0, 2] = "Holanda";
            resultados[1, 2] = "Alemanha";
            resultados[2, 2] = "Alemanha";
            Imprime(x, y, resultados);
            Console.WriteLine();

            x = 4;
            y = 3;
            string[,] resultados2 = new string[x, y];
            resultados2[0, 0] = "Alemanha";
            resultados2[1, 0] = "Espanha";
            resultados2[2, 0] = "Itália";
            resultados2[3, 0] = "Brasil";

            resultados2[0, 1] = "Argentina";
            resultados2[1, 1] = "Holanda";
            resultados2[2, 1] = "França";
            resultados2[3, 1] = "Uruguai";

            resultados2[0, 2] = "Holanda";
            resultados2[1, 2] = "Alemanha";
            resultados2[2, 2] = "Alemanha";
            resultados2[3, 2] = "Portugal";
            Imprime(x, y, resultados2);

            Console.ReadLine();
        }

        private static void Imprime(int x, int y, string[,] resultados)
        {
            //Console.WriteLine("Imprime lista desordenada:");
            //foreach (var selecao in resultados)
            //{
            //    Console.WriteLine(selecao);
            //}
            //Console.WriteLine();

            Console.WriteLine("Imprime lista ordenada:");
            for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++)
            {
                int ano = 2014 - copa * 4;
                Console.Write(ano.ToString().PadRight(12));
            }
            Console.WriteLine();
            for (int copa = 0; copa <= resultados.GetUpperBound(0); copa++)
            {
                for (int time = 0; time <= resultados.GetUpperBound(1); time++)
                {
                        Console.Write(resultados[copa, time].PadRight(12));
                }
                Console.WriteLine();
            }
        }
    }
}
