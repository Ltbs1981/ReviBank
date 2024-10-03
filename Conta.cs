using System;

namespace ReviBank
{
    public abstract class Conta
    {
        public abstract string Nome { get; set; }
        public abstract string NumeroConta { get; protected set; }
        public abstract double  Saldo { get; protected set; }

        public Conta(string nome, string numeroConta)
        {
            Nome = nome;
            NumeroConta = numeroConta;
        }

        public Conta(string nome, string numeroConta, double saldo) : this(nome, numeroConta)
        {
            Saldo = saldo;
        }

        public abstract void Depositar(double valor);

        public abstract void Sacar(double valor);

        public override string ToString()
        {
            return $"Titular: {Nome}\t Número da Conta: {NumeroConta}\t Saldo: {Saldo:F2}";
        }
    }
}
