using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcollectionsp2
{
    class Aula2SortedDictionary
    {
        static void Aula2Main(string[] args)
        {
            //Criação de dicionário
            //VT, Vanessa, 34672
            //AL, Ana, 5617
            //RN, Rafael, 17645
            //WM, Wanderson, 11287

            IDictionary<string, Aluno> sorted = new SortedDictionary<string, Aluno>();
            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));


            foreach (var aluno in sorted)
            {
                Console.WriteLine(aluno);
            }


            Console.ReadLine();
        }
    }
}
