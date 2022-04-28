using System;

namespace Ano_bisexto
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            
            Console.WriteLine("Digite um ano para saber se é bissexto");
            ano = Convert.ToInt32(Console.ReadLine());

            if (ano % 4 == 0 && ano % 400 == 0 || ano % 100 != 0)
            {
                Console.WriteLine("É um ano bissexto.");
            }
            else
                Console.WriteLine("Não é ano Bissexto.");

        }
    }
}
//Faça um programa que calcule e mostre se um ano é bissexto.
//Observações:
//a.Um ano é bissexto quando este é divisível por 4 mas não é
//divisível por 100.
//b. Um ano é bissexto quando é divisível por 400.
//c. Caso o ano seja divisível por 4, deverá verificar se este é
//divisível por 400. Caso seja, é bissexto, caso não seja, não
//será bissexto.