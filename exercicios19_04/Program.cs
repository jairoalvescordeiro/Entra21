using System;

namespace entra21_menor_maior_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string nome;
            Console.WriteLine("Digite sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite seu nome compeleto:");
            nome = Console.ReadLine();

            if (idade>=18)
                    Console.WriteLine(nome + " você é maior de idade.");
                else 
                Console.WriteLine (nome + " você não é maior de idade.");
        }
    }
}
