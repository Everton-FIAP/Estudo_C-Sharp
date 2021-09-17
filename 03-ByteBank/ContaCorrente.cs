using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class ContaCorrente
    {
        private string titular;
        private int agencia;
        private int numero;
        private double saldo;

        public ContaCorrente() { }
        public ContaCorrente(string titular, int agencia, int numero, double saldo)
        {
            this.titular = titular;
            this.agencia = agencia;
            this.numero = numero;
            this.saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if(this.saldo > valor)
            {
                this.saldo -= valor;
            }
        }

        public void Depositar(double valor)
        {
            if(valor > 0)
            {
                this.saldo += valor;
            }
        }

        public void Transferir(ContaCorrente conta, double valor)
        {
            if(valor < this.saldo)
            {
                this.saldo -= valor;
                conta.saldo += valor; 
            }
        }



        public string ToString()
        {
            return "titular=" + this.titular + ", agencia=" + this.agencia + ", numero=" + this.numero + ", saldo= " + this.saldo;
        }
    }
}
