using System;

namespace att01
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite o valor do produto: ");
			double preco_produto = Convert.ToDouble(Console.ReadLine());
					
				
			Console.Write("Desconto em %: ");
			double desconto = Convert.ToDouble(Console.ReadLine());
			
			double valor_desconto = (desconto / 100) * preco_produto;
			double valor_total = preco_produto - valor_desconto;
			
			Console.WriteLine("\r\nPreço com desconto: R$" + valor_total);
			
						
			Console.Write("\r\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
