using System.Globalization;

namespace CalcularMediaDeNotas
{
	internal class CalcularNotas
	{
		public int Quantidade;
		public double[] Notas;
		

		public void CalcularMedia()
		{
			for (int i = 0; i < Quantidade; i++)
			{
				Console.WriteLine($"DIGITE A NOTA: {i + 1}");
				Notas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			}

			double soma = 0;

			for (int i = 0; i < Quantidade; i++)
			{
				soma += Notas[i];
			}

			double media = soma / Quantidade;
            Console.WriteLine($"SUA MÉDIA: {media.ToString("f1", CultureInfo.InvariantCulture)}");
        }


	}
}
