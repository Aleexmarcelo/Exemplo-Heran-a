using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_Herança
{

        //Subclasse que recebe a herança da classe Conta
        public class ContaJuridica : Conta
        {
            //Encapsulamento da variável EmprestimoLimite
            public double EmprestimoLimite { get; set; }
            //Construtor comum
            public ContaJuridica()
            {
            }
            //Construtor personalizado
            public ContaJuridica(int numero, string titular, double saldo, double emprestimoLimite) : base(numero, titular, saldo)
            {
                EmprestimoLimite = emprestimoLimite;
            }
            //Método Emprestimo
            public void Emprestimo(double saldoTotal)
            {
                //Condição
                if (saldoTotal <= EmprestimoLimite)
                {
                    Saldo += saldoTotal;
                }
            }
        }
    }

