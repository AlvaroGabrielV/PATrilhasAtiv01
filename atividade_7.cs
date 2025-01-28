using System;

namespace att01
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um nome: ");
			string nome = Convert.ToString(Console.ReadLine());
					
				
			Console.Write("Digite a idade: ");
			int idade = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("\r\nNome: " + nome);
			Console.WriteLine("Idade: " + idade);
			
			Console.Write("\r\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
