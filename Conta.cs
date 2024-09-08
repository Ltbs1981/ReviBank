using System;

namespace ReviBank
{
    public class Conta
    {
        public string Nome { get; set; }
        public string NumeroConta { get; private set; }
        public double Saldo { get; private set; }

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
            if (valor + 5.00 > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
            else
            {
                Saldo -= valor + 5.00; // taxa de saque
            }
        }

        public override string ToString()
        {
            return $"Titular: {Nome}\tConta: {NumeroConta}\tSaldo: {Saldo:F2}";
        }
    }
}
