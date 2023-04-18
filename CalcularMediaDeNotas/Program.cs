using System;

namespace CalcularMediaDeNotas
{
	internal class Program
	{
		static void Main(string[] args)
		{

			CalcularNotas notas = new CalcularNotas();

			Console.WriteLine("BEM VINDO AO CALCULADOR DE NOTAS!");
			Console.WriteLine("=================================");
			Console.Write("QUAL A QUANTIDADE DE NOTAS? ");
			notas.Quantidade = int.Parse(Console.ReadLine());

			notas.Notas = new double[notas.Quantidade];

			notas.CalcularMedia();
		}
	}
}