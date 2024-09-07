using System;

namespace ReviBank
{
    public class Conta
    {
        public string Nome;
        public string NumeroConta;
        public double Saldo;

        public Conta(string nome, string numeroConta)
        {
            Nome = nome;
            NumeroConta = numeroConta;
        }

        public Conta(string nome, string numeroConta, double saldo) : this(nome, numeroConta)
        {
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 5.00;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"{Nome}\n{NumeroConta}\n{Saldo}");
        }
    }
}
