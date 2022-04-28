using System;

namespace salario_trabalhador
{
    class Program
    {
        static void Main(string[] args)
        {

            float salario;
            float salarioReajuste;
            float salarioDolar;
            float salarioEuro;
            float dolar;
            float euro;


            Console.WriteLine("Digite o valor do salário");
            salario = Convert.ToSingle(Console.ReadLine());


            dolar = 4.70f;
            euro = 5.20f;


            if (salario <= 1200)
            {
                salarioReajuste = (salario + (salario / 100) * 20);
                
                Console.WriteLine("Salário com reajuste é: R$: " + (salario + (salario / 100) * 20));
                Console.WriteLine("\n");
                Console.WriteLine("Salário em Dólar é: $ " + (salarioReajuste / dolar));
                Console.WriteLine("\n");
                Console.WriteLine("Salário em Euro é: $ " + (salarioReajuste / euro));
            }
            else if ((salario >= 1201) && (salario <= 2000))
                    {
                salarioReajuste = (salario + (salario / 100) * 13);

                Console.WriteLine("Salário com reajuste é: R$  " + (salario + (salario / 100) * 13)); Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("Salário em Dólar é: $ " + (salarioReajuste / dolar));
                Console.WriteLine("\n");
                Console.WriteLine("Salário em Euro é: $ " + (salarioReajuste / euro));

            }
            else if ((salario >= 2001) && (salario <= 2500))
            {
                salarioReajuste = (salario + (salario / 100) * 10);

                Console.WriteLine("Salário com reajuste é: R$: " + (salario + (salario / 100) * 10));
                Console.WriteLine("\n");
                Console.WriteLine("Salário em Dólar é: $ " + (salarioReajuste / dolar));
                Console.WriteLine("\n");
                Console.WriteLine("Salário em Euro é: $ " + (salarioReajuste / euro));
            }
            if (salario >= 2501)
            {
                salarioReajuste = (salario + (salario / 100) * 5);

                Console.WriteLine("Salário com reajuste é: R$: " + (salario + (salario / 100) * 5));
                Console.WriteLine("\n");
                Console.WriteLine("Salário em Dólar é: $ " + (salarioReajuste / dolar));
                Console.WriteLine("\n");
                Console.WriteLine("Salário em Euro é: $ " + (salarioReajuste / euro));
            }


        }
    }
}
//Faça um programa que receba o salário de um colaborador, calcule
//e mostre:
//a.Valor após o reajuste, conforme a tabela abaixo;
//● Até R$ 1200: 20 % de aumento;
//● Até R$ 2000: 13 % de aumento;
//● Até R$ 2500: 10 % de aumento;
//● Acima de R$ 2500: 5 % de aumento;
//b.Valor total representado pelo acréscimo;
//c.Valor do salário em Dólares(considerar a cotação a R$4, 70);
//d.Valor do salário em Euros(considerar a cotação a R$5, 20);
