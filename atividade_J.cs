
using System;

namespace att01
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite a rua: ");
			string rua = Console.ReadLine();
			
			Console.Write("Digite o numero: ");
			string numero = Console.ReadLine();
			
			Console.Write("Digite o bairro: ");
			string bairro = Console.ReadLine();
			
			Console.Write("Digite a cidade: ");
			string cidade = Console.ReadLine();
			
			Console.Write("Digite o estado: ");
			string estado = Console.ReadLine();
			
			Console.WriteLine("\r\nEndereço: " + rua + " n°" + numero + " " + bairro + " - " + cidade + "/" + estado);
					
						
			Console.Write("\r\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
