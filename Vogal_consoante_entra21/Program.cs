using System;

namespace Vogal_ou_Consoante
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.WriteLine("Digite uma letra para saber se é vogal ou consoante:");
            letra = Convert.ToChar(Console.ReadLine());
            if ((letra == 'a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u'))

                Console.WriteLine("É uma vogal.");

            else
                Console.WriteLine("É uma consoante.");

        }
       
    }
}
//Faça um programa que receba uma letra e diga se esta é uma vogal
//ou consoante.