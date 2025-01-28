using System;

namespace att00
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Digite SIM ou NAO: ");
			string escolha = Console.ReadLine();
			
			if (escolha == "SIM"){
				bool estado = true;
				Console.WriteLine("O usuario escolheu: " + estado);
			}
			else if (escolha == "NAO" ) {
				bool estado = false;
				Console.WriteLine("O usuario escolheu: " + estado);
			}
				
			Console.WriteLine();
			Console.WriteLine("Aperte qualquer tecla para continuar...");
			Console.ReadKey();
		}
	}
}
