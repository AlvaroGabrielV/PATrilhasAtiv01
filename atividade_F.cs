using System;

namespace att00
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um numero: ");
			decimal numero = Convert.ToDecimal(Console.ReadLine());
			
			Console.WriteLine("\r\nO numero inserido é: " + numero);
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
