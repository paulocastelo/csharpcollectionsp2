using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcollectionsp2
{
    class Aula1SortedList
    {
        static void Aula1Main(string[] args)
        {
            //Criação de dicionário
            //VT, Vanessa, 34672
            //AL, Ana, 5617
            //RN, Rafael, 17645
            //WM, Wanderson, 11287
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();

            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine();

            alunos.Remove("AL");

            alunos.Add("MO", new Aluno("Marcelo", 12345));


            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine();

            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();
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
