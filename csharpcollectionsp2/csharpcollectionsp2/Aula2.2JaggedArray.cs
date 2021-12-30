using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcollectionsp2
{
    class Aula2_2_JaggedArrays
    {
        static void ImprimirJagged(string[] args)
        {
            Aula22JaggedArrays();

            Console.ReadLine();
        }

        private static void Aula22JaggedArrays()
        {
            //família 1: Família Flintstone
            //família 2: Família Simpsons
            //família 3: Família Dona Florinda
            string[][] familias = new string[3][];
            //{
            //    { "Fred", "Wilma", "Pedrita" },
            //    { "Homer", "Marge", "Lisa", "Bart", "Maggie"},
            //    { "Dona Florinda", "Kiko" }
            //};

            familias[0] = new string[] { "Fred", "Wilma", "Pedrita" };
            familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
            familias[2] = new string[] { "Dona Florinda", "Kiko" };

            foreach (var familia in familias)
            {
                Console.WriteLine(string.Join(", ", familia));
            }
        }
    }
}
