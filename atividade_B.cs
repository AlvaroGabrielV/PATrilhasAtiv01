using System;

namespace att00
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um numero: ");
			double numero = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("O numero inserido é: " + numero);
			Console.WriteLine();
			Console.WriteLine("Aperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
