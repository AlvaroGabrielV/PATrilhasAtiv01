using System;

namespace att00
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Digite uma letra do alfabeto: ");
			char letra = Convert.ToChar(Console.ReadLine());
			Console.WriteLine("A letra digita foi: " + letra);
			

			Console.WriteLine();
			Console.WriteLine("Aperte qualquer tecla para continuar...");
			Console.ReadKey();
		}
	}
}
