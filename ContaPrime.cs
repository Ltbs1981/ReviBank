using System;

namespace ReviBank
{
    public sealed class ContaPrime : Conta
    {
        public int PontosEmMilhas { get; set; }
        public double ChequeEspecial { get; set; }

        public override string Nome { get; set; }
        public override string NumeroConta { get; protected set; }
        public override double Saldo { get; protected set; }

        public ContaPrime(string nome, string numeroConta, int pontosEmMilhas) : base(nome, numeroConta)
        {
            PontosEmMilhas = pontosEmMilhas;
            ChequeEspecial = 100000;
            Saldo = 0;
        }

        public ContaPrime(string nome, string numeroConta, double saldo, int pontosEmMilhas) : base(nome, numeroConta, saldo)
        {
            PontosEmMilhas = pontosEmMilhas;
            ChequeEspecial = 100000;
        }

        public override void Depositar(double valor)
        {
            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
            else
            {
                Console.WriteLine($"O valor de R$ {valor} foi retirado da sua conta");
                Saldo -= valor + 20.00;
            }
        }

        public override string ToString()
        {
            return $"Titular: {Nome}\n Número da Conta: {NumeroConta}\n Saldo: {Saldo:F2}\n Milhas: {PontosEmMilhas}\n Cheque Especial: {ChequeEspecial:F2}";
        }
    }
}

