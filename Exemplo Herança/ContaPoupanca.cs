using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_Herança
{
    class ContaPoupanca : Conta
    {

        //Variavel Juros
        public double TaxaJuros { get; set; }
        //Construtor comum
        public ContaPoupanca()
        {
        }
        //Construtor personalizado
        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }
        //Método Atualizando saldo
        public void atualizacaoSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
        //Método com overide
        public override void Saque(double saldoTotal)
        {
            base.Saque(saldoTotal);
            //Taxa do banco
            Saldo -= 2.0;
        }
    }
}
