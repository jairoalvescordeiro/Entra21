using System;

namespace escolhendo_operacoes_function_entra21
{
    class Program
    {
        static void Main(string[] args)

        {
            //Faça um programa com um menu que receba uma opção, e de acordo com a opção, efetue uma operação(uma função ou procedimento) conforme abaixo e mostre em
            //tela o resultado. O usuário deve poder efetuar quantas operações quiser.
            //1 – Adição;
            //2 – Subtração;
            //3 – Multiplicação;
            //4 – Divisão(não permitir divisão por zero);
            //0 – Sair.


            Console.WriteLine("Escolha o tipo de operação: 1 (Somar), 2 (Subtrair), 3 (Multiplicar), 4 (Dividir):");
            string operacao = Console.ReadLine();
            

            Console.WriteLine("Digite o primeiro valor:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("Digite o segundo valor");
            double n2 = Convert.ToDouble(Console.ReadLine());
            
            double res;

            if (operacao == "3") 
            {
                res = multiplicar(n1, n2);
                Console.WriteLine("A multiplicação é: " + res);
            }
                
            else if (operacao == "1")
            {
                res = somar(n1, n2);
                Console.WriteLine("A soma é: " + res);
            }

            else if (operacao == "2")
            {
                res = subtrair(n1, n2);
                Console.WriteLine("A subtração é: " + res);
            }

            else if (operacao == "4")
            {
                res = dividir(n1, n2);
                Console.WriteLine("A divisão é: " + res);
            }
        }
        static double multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }
        static double somar(double n1, double n2)
        {
            return n1 + n2;
        }
        static double subtrair(double n1, double n2)
        {
            return n1 - n2;
        }
        static double dividir(double n1, double n2)
        {
           return n1 / n2;
        }
    }
}
