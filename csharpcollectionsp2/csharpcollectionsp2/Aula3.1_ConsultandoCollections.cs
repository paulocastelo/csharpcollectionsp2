using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcollectionsp2
{
    class Aula4_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String para object:");
            string titulo = "meses";
            object obj = titulo;
            Console.WriteLine(obj);
            Console.WriteLine();

            Console.WriteLine("List<string> para List<object>:");
            IList<string> listaMeses = new List<string>
            {
                "janeiro","fevereiro","março",
                "abril","maio","junho",
                "julho","agosto","setembro",
                "outubro","novembro","dezembro"
            };
            //IList<object> listObj = listaMeses;
            Console.WriteLine();
            Console.WriteLine("String[] para Object[]:");
            int tamanho = listaMeses.Count();
            string[] arrayMeses = new string[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                arrayMeses[i] = listaMeses[i];
            }
            ImprimeConsulta(arrayMeses);
            Object[] arrayObj = arrayMeses; //COVARIÂNCIA
            foreach (var item in arrayMeses)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        private static void Aula4_2()
        {
            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            Console.WriteLine("Usando concat:");
            var consulta = seq1.Concat(seq2);
            ImprimeConsulta(consulta);

            Console.WriteLine("Usando Union:");
            var consulta2 = seq1.Union(seq2);
            ImprimeConsulta(consulta2);

            Console.WriteLine("Usando Union com IgnoreCase:");
            var consulta3 = seq1.Union(seq2, StringComparer.CurrentCultureIgnoreCase);
            ImprimeConsulta(consulta3);

            Console.WriteLine("Usando Intersect com IgnoreCase:");
            var consulta4 = seq1.Intersect(seq2, StringComparer.CurrentCultureIgnoreCase);
            ImprimeConsulta(consulta4);

            Console.WriteLine("Usando Except com IgnoreCase:");
            var consulta5 = seq1.Except(seq2, StringComparer.CurrentCultureIgnoreCase);
            ImprimeConsulta(consulta5);
        }

        private static void ImprimeConsulta(IEnumerable<string> consulta)
        {
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            };
            Console.WriteLine();
        }

        private static void Aula4_1()
        {
            List<Mes> meses = new List<Mes>()
            {

                  new Mes("Janeiro",31)
                 ,new Mes("Fevereiro",28)
                 ,new Mes("Março",31)
                 ,new Mes("Abril",31)
                 ,new Mes("Maio",31)
                 ,new Mes("Junho",30)
                 ,new Mes("Julho",31)
                 ,new Mes("Agosto",31)
                 ,new Mes("Setembro",30)
                 ,new Mes("Outubro",31)
                 ,new Mes("Novembro",30)
                 ,new Mes("Dezembro",31)
            };
            //Consulta 01
            Console.WriteLine("Primeiro trimestre:");
            var consulta = meses.Take(3);
            ImprimeConsultaMes(consulta);

            //Consulta 02
            Console.WriteLine("Segundo trimestre:");
            var consulta2 = meses.Skip(3)
                                  .Take(3);
            ImprimeConsultaMes(consulta2);

            //Consulta 03
            Console.WriteLine("Teceiro trimestre:");
            var consulta3 = meses.Skip(6)
                                  .Take(3);
            ImprimeConsultaMes(consulta3);

            //Consulta 04
            Console.WriteLine("Lista até o 1º mês iniciado com a letra S:");
            var consulta4 = meses.TakeWhile(mes => !mes.Nome.StartsWith("S"));
            ImprimeConsultaMes(consulta4);

            //Consulta 05
            Console.WriteLine("Iniciar lista a partir do mês iniciado com a letra S:");
            var consulta5 = meses.SkipWhile(mes => !mes.Nome.StartsWith("S"));
            ImprimeConsultaMes(consulta5);

            //Consulta 06
            Console.WriteLine("Iniciar lista a partir do mês iniciado com a letra S:");
            var consulta6 = meses.Skip(9);
            ImprimeConsultaMes(consulta6);
        }

        private static void ImprimeConsultaMes(IEnumerable<Mes> consulta)
        {
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        private static void Aula3_1()
        {
            List<Mes> meses = new List<Mes>()
            {

                  new Mes("Janeiro",31)
                 ,new Mes("Fevereiro",28)
                 ,new Mes("Março",31)
                 ,new Mes("Abril",31)
                 ,new Mes("Maio",31)
                 ,new Mes("Junho",30)
                 ,new Mes("Julho",31)
                 ,new Mes("Agosto",31)
                 ,new Mes("Setembro",30)
                 ,new Mes("Outubro",31)
                 ,new Mes("Novembro",30)
                 ,new Mes("Dezembro",31)
            };

            Console.WriteLine("Impressão de lista utilizando Foreach:");

            List<Mes> novaLista = new List<Mes>();
            foreach (var mes in meses)
            {
                novaLista.Add(mes);
            }
            novaLista.Sort();

            foreach (var mes in novaLista)
            {
                if (mes.Dias == 31)
                {
                    Console.Write("Mês: " + mes.Nome.ToUpperInvariant() + " - Dias: " + mes.Dias + "\n");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Impressão de lista utilizando LINQ");

            //Comentado para permitir o ToUpperInvariant
            //IEnumerable<Mes> consulta = meses
            IEnumerable<string> consulta = meses
                                        .Where(mes => mes.Dias == 31)
                                        .OrderBy(mes => mes.Nome)
                                        .ToArray()
                                        .Select(mes => mes.Nome.ToUpper())
                                        ;
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Mes : IComparable
    {
        public string Nome { get; set; }
        public int Dias { get; set; }
        public Mes(string nome, int dias)
        {
            Nome = nome;
            Dias = dias;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Mês: " + Nome);
            sb.Append(" - Dias: " + Dias);
            return sb.ToString();
        }

        public int CompareTo(object obj)
        {
            var outroMes = obj as Mes;
            if (outroMes == null)
            {
                return -1;
            }
            return this.Nome.CompareTo(outroMes.Nome);
        }
    }
}
