using System;

public class minhaClasse
{

	public static void Main(string[] args)
	{

		double nota1, nota2;
		double media;

		nota1 = Convert.ToDouble(Console.ReadLine().Replace(",", "."));

		while (nota1 < 0 || nota1 > 10)
		{
			Console.WriteLine("nota invalida");
			nota1 = Convert.ToDouble(Console.ReadLine().Replace(",", "."));
		}

		nota2 = Convert.ToDouble(Console.ReadLine().Replace(",", "."));

		while (nota2 < 0 || nota2 > 10)
		{
			Console.WriteLine("nota invalida");
			nota2 = Convert.ToDouble(Console.ReadLine().Replace(",", "."));
		}

		media = (nota1 + nota2) / 2;
		Console.WriteLine("media = {0:0.00}", media);
	}
}