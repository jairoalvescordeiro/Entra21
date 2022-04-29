using System;

namespace Exercio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            string operacao;
            

            Console.WriteLine("Digite o primeiro número:");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o tipo de operação que você quer. Dividir, Multiplicar, Somar, Subtrair:");
            operacao = Console.ReadLine();


            if (operacao == "Dividir" || operacao == "dividir")
                Console.WriteLine(numero1 / numero2);

            if (operacao == "Multiplicar" || operacao == "multiplicar")
                Console.WriteLine(numero1 * numero2);

            if (operacao == "Somar" || operacao == "somar")
                Console.WriteLine(numero1 + numero2);

            if (operacao == "Subtrair" || operacao == "subtrair")
                Console.WriteLine(numero1 - numero2);

        }
    }
}
