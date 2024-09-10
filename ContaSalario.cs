using System;

namespace ReviBank
{
    public class ContaSalario : Conta
    {
        public string NomeEmpresa { get; set; }
        public double Emprestimo { get; set; }

        public ContaSalario(string nome, string numeroConta, string nomeEmpresa) : base(nome, numeroConta)
        {
            NomeEmpresa = nomeEmpresa;
            Emprestimo = 10000;
        }

        public ContaSalario(string nome, string numeroConta, double saldo, string nomeEmpresa) : base(nome, numeroConta, saldo)
        {
            NomeEmpresa = nomeEmpresa;
            Emprestimo = 10000;
        }

        public override string ToString()
        {
            return $"Titular: {Nome}\n Número da Conta: {NumeroConta}\n Saldo: {Saldo:F2}\n Empresa: {NomeEmpresa}\n Disponível para Empréstimo: {Emprestimo}";
        }
    }
}
