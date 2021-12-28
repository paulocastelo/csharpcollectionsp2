using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcollectionsp2
{
	class Aula1_3SortedSet
	{
		static void Aula13SortedSet(String[] args)
		{

			ISet<string> alunos = new HashSet<string>
			{
			"Priscila Stuani"
			,"Rafael Rollo"
			,"Fábio Gushiken"
			,"Ana Losnak"
			,"Fábio Gushiken"
			};

			alunos.Add("Vanessa Tonini");
			alunos.Add("Rafael Rocco");
			alunos.Add("Marcelo Oliveira");
			alunos.Add("Vanessa Tonini");
			alunos.Add("Vanessa TONIni");

			foreach (var aluno in alunos)
			{
				Console.WriteLine(aluno);
			}
			Console.WriteLine();

			ISet<string> alunos2 = new SortedSet<string>(new ComparadorMinusculo())
			{
			"Priscila Stuani"
			,"Rafael Rollo"
			,"Fábio Gushiken"
			,"Ana Losnak"
			,"Fábio Gushiken"
			};

			alunos2.Add("Vanessa Tonini");
			alunos2.Add("Rafael Rocco");
			alunos2.Add("Marcelo Oliveira");
			alunos2.Add("Vanessa Tonini");
			alunos2.Add("Vanessa TONIni");

			foreach (var aluno in alunos2)
			{
				Console.WriteLine(aluno);
			}
			Console.WriteLine();

			ISet<string> outroConjunto = new HashSet<string>();
			Console.WriteLine(alunos2.IsSubsetOf(outroConjunto));
			Console.WriteLine(alunos2.IsSupersetOf(outroConjunto));
			Console.WriteLine(alunos2.SetEquals(outroConjunto));
			alunos2.ExceptWith(outroConjunto);
			alunos2.IntersectWith(outroConjunto);
			alunos2.SymmetricExceptWith(outroConjunto);
			alunos2.UnionWith(outroConjunto);



			Console.ReadLine();
		}
	}

	internal class ComparadorMinusculo : IComparer<string>
	{
		public int Compare(string x, string y)
		{
			return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
		}
	}
}
