using System;

namespace Conta_bancaria_entra21
{
    class Program
    {
        static void Main(string[] args)
        {

            //Faça um programa que tenha um menu para fazer operações entre contas bancárias.
            //Para as contas, usar dois arrays de 5 posições, em um registrando a conta da pessoa e no outro, os valores iniciais de cada conta (2 vetores, cada um com 5 posições,
            //um recebendo a conta e outro os valores respectivos das contas).Deve ser possível fazer as seguintes operações no menu, de acordo com a entrada do usuário:
            //1 - Sacar: o usuário deve indicar a conta da qual fará o saque (esta deve possuir saldo suficiente para a operação);
            //2 - Depositar: o usuário deve indicar para qual conta irá o valor;
            //3 - Transferir: o usuário deve indicar de qual conta sairá(esta deve ter saldo suficiente para a operação), o valor da transferência e para qual conta irá os valores.
            //0 - Para finalizar a execução do programa

            string nome1;
            string nome2;
            double[] conta1 = new double[5];
            double[] conta2 = new double[5];
            double[] valorConta1 = new double[5];
            double[] valorConta2 = new double[5];
            
            Console.WriteLine("Insira nome:");
            nome1 = Console.ReadLine();

            Console.WriteLine("Insira nome:");
            nome1 = Console.ReadLine();



        }
    }
}
