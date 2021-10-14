using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_Herança
{
    public class Conta
    {
        //Variáveis com encapsulamento
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }
        //Construtor comum
        public Conta()
        {
        }
        //Construtor personalizado
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        //Métodos de Saque e Depósito
        public void Saque(double saldoTotal)
        {
            Saldo -= saldoTotal;
        }
        public void Deposito(double saldoTotal)
        {
            Saldo += saldoTotal;
        }
    }
}
