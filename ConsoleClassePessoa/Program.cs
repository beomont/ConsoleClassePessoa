using System;

namespace ConsoleClassePessoa
{
	class Program
	{
		static void Main(string[] args)
		{
			Pessoa pessoa = new Pessoa();

			Console.WriteLine("Digite seu nome: ");
			pessoa.nome = Console.ReadLine();

			Console.WriteLine("Digite sua idade: ");
			pessoa.idade = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Digite seu RG: ");
			pessoa.rg = Console.ReadLine();

			Console.WriteLine("Digite seu CPF: ");
			pessoa.cpf = Console.ReadLine();


			Console.WriteLine("Nome: {0}", pessoa.nome);
			Console.WriteLine("Idade: {0}", pessoa.idade);
			Console.WriteLine("RG: {0}", pessoa.rg);
			Console.WriteLine("CPF: {0}", pessoa.cpf);

			Pessoa pessoaSabrina = new Pessoa();
			pessoaSabrina.nome = "Sabrina Kopehagen";
			pessoaSabrina.idade = 46;
			pessoaSabrina.rg = "00.004.555-74";
			pessoaSabrina.cpf = "464.848.777-85";

			Console.WriteLine("Nome: {0}", pessoaSabrina.nome);
			Console.WriteLine("Idade: {0}", pessoaSabrina.idade);
			Console.WriteLine("RG: {0}", pessoaSabrina.rg);
			Console.WriteLine("CPF: {0}", pessoaSabrina.cpf);

			pessoa.Acenar(pessoaSabrina);
			pessoa.PerguntaIdade(pessoaSabrina);


		}
	}
}
