using System;

namespace Exemplo_Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrar com dados da conta com nome, numero e saldo
            Console.WriteLine("Número da conta: ");
            int Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome do cliente: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Saldo: ");
            double Saldo = int.Parse(Console.ReadLine());

            //Cria a conta juridica com os dados digitados
            ContaJuridica conta = new ContaJuridica(Numero, Nome, Saldo, 500.0);

            //Printa o saldo atual da conta
            Console.WriteLine("Seu saldo atual é: " + "R$" + conta.Saldo);
        }
    }
}
