using System;

namespace ReviBank
{
    public sealed class ContaSalario : Conta
    {
        public string NomeEmpresa { get; set; }
        public double Emprestimo { get; set; }

        public override string Nome { get; set; }
        public override string NumeroConta { get; protected set; }
        public override double Saldo { get; protected set; }

        public ContaSalario(string nome, string numeroConta, string nomeEmpresa) : base(nome, numeroConta)
        {
            NomeEmpresa = nomeEmpresa;
            Emprestimo = 10000;
            Saldo = 0;
        }

        public ContaSalario(string nome, string numeroConta, double saldo, string nomeEmpresa) : base(nome, numeroConta, saldo)
        {
            NomeEmpresa = nomeEmpresa;
            Emprestimo = 10000;
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
                Saldo -= valor + 5.00;
            }
        }

        public override string ToString()
        {
            return $"Titular: {Nome}\n Número da Conta: {NumeroConta}\n Saldo: {Saldo:F2}\n Empresa: {NomeEmpresa}\n Disponível para Empréstimo: {Emprestimo}";
        }
    }
}
