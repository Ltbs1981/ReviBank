using System;

namespace ReviBank
{
    public class Conta
    {
        public string Nome;
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
            if(valor > Saldo) {
                Console.WriteLine($"Saldo insuficiente, você só tem R$ {Saldo}");
            }else {
                Saldo -= valor + 5.00;
            }
            
        }
        public override string ToString()
        {
            return ($"Titular: {Nome}\tConta: {NumeroConta}\tSaldo: {Saldo}");
        }
    }
}
