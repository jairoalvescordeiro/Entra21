using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba o valor de um produto e o percentual de desconto
            //mostre o valor do produto com o desconto e calcule os impostos
            //(com base no valor sem desconto) sobre e mostre também em tela:
            //Valor até 100: alíquota de 5 %;
            //Valor entre 101 e 300: alíquota de 15 %;
            //Valor entre 301 e 1000: alíquota de 25 %;

            float valor;
            float desconto;

                

            Console.WriteLine("Digite o preço do produto;");
                valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o percentual de desconto:");
                desconto = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("O Valor da sua compra é de R$ :" + (valor/100) * (valor - desconto));
            Console.WriteLine("O Valor da sua compra é de R$ :" + (valor - ((valor / 100) * desconto)));

            if (valor <= 100)
            {
                Console.WriteLine("O imposto é de: R$: " + (valor / 100) * 5);
            }

            else if ((valor >= 101) && (valor <= 300)) {
                Console.WriteLine("O imposto é de: R$: " + (valor / 100) * 15);
            }

            else if (valor >= 301) {
                Console.WriteLine("O imposto é de: R$: " + (valor / 100) * 25);
            }







        }
    }
}
