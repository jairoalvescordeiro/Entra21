using System;

namespace Calcula_Raiz
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c;
            double delta;
            double raiz;
            double r1;
            double r2;


            Console.WriteLine("Digite o valor de A, B e C:");
            a = Convert.ToDouble(Console.ReadLine());
               if (a == 0) Console.WriteLine("Está não é uma equação do segundo grau, digite um valor maior que ZERO.");
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            delta = (b * b) - (4 * a * c);
                if (delta < 0) 
                    Console.WriteLine("Não há raizes reais, Delta não pode ser negativo:");
                else if (delta > 0)
            {
                Console.WriteLine("Delta maior que ZERO, háverá duas raizes.");
            }
            
            raiz = Math.Sqrt(delta);
            
            r1 = ((-(b)) + raiz) / (2 * a);
                Console.WriteLine("Valor primeira Raiz:" + r1);
            
            r2 = ((-(b)) - raiz) / (2 * a);
                Console.WriteLine("Valor segunda Raiz:" + r2);



        }


    }
}
//Escreva um programa que calcule as raízes de uma equação do
//segundo grau (ax^2 + bx + c
//Observações:
//a. Se o delta calculado for negativo, então não haverão raízes
//reais, o programa deve ser encerrado e isto deverá ser
//informado ao usuário;
//b.Caso o delta calculado seja igual a zero, haverá apenas uma
//raiz. Esta deverá ser informada ao usuário.
//c. Caso o delta seja maior que zero, haverá duas raízes reais.
//Mostre-as ao usuário.