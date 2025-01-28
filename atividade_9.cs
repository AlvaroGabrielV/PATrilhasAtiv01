using System;

namespace att01
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite uma palavra: ");
			string texto = Console.ReadLine();
					
			Console.WriteLine("\r\nO tamanho desse texto é: " + texto.Length);
						
			Console.Write("\r\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
