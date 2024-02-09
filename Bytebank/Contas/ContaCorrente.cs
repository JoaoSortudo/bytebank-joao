using Bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Contas
{
    public class ContaCorrente
    {
        public int numeroAgencia;
        public string conta;
        private double saldo = 100;

        public ContaCorrente(Cliente titular, string nome_agencia, int numero_agencia, string conta)
        {
            Titular = titular;
            Nome_Agencia = nome_agencia;
            Numero_agencia = numero_agencia;
            Conta = conta;
        }


        public Cliente titular;

        public Cliente Titular { get; private set; }
        public string Nome_Agencia { get; private set; }
        public int Numero_agencia { get; set; }
        public string Conta { get; private set; }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular:" + titular);
            Console.WriteLine("Conta:" + conta);
            Console.WriteLine("Número da Agência:" + numeroAgencia);
            Console.WriteLine("Saldo: " + saldo);
        }


        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }

            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }
    }
}
