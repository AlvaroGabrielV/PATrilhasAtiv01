using System;

namespace att00
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um numero: ");
			int age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("O numero inserido é: " + age);
			Console.WriteLine();
			Console.WriteLine("Aperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
