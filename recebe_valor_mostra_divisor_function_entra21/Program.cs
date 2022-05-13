using System;

namespace Funcao_recebe_valor_mostra_divisor_entra21
{
    class Program
    {
            public static void mostraDivisor()
            {
            double numero;
            double contador = 1;
            double[] divisores = new double[numero];

            Console.WriteLine("Digite um número: ");
                numero = double.Parse(Console.ReadLine());

            for (int i = 1; i<= numero / 2; i++)
            {
                if (numero % 1 == 0)
                {
                    contador++;
                }
                for (int i = 0; i < divisores.Length; i++)
                {

                }
            }
            
            
            Console.WriteLine("Você digitou:" + numero);
            Console.WriteLine("Divisor:" + contador);

            }
 
        static void Main(string[] args)
            {
                mostraDivisor();
           
            
            }
     


    }
}

//Faça um programa que receba um valor e, usando uma função, receba esse valor 
//e retorne e mostre todos os divisores entre 0 e o número;
