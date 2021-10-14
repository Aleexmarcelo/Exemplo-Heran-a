using System;

namespace Exemplo_Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrar com dados da conta com nome, numero e saldo
            Console.WriteLine("Envie o seu número da conta: ");
            int Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Envie o seu nome: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Envie o seu saldo atual: ");
            double Saldo = int.Parse(Console.ReadLine());

            //Cria a conta juridica com os dados digitados
            ContaJuridica conta = new ContaJuridica(Numero, Nome, Saldo, 500.0);

            //Printa o saldo atual da conta
            Console.WriteLine("Seu saldo atual é de: " + "R$" + conta.Saldo);
        }
    }
}
