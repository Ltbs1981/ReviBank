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
        }

        public ContaSalario(string nome, string numeroConta, double saldo, string nomeEmpresa) : base(nome, numeroConta, saldo)
        {
            NomeEmpresa = nomeEmpresa;
        }

        public override string ToString()
        {
            return $"Titular: {Nome}\t Conta: {NumeroConta}\t Saldo: {Saldo:F2}\t Empresa: {NomeEmpresa}";
        }
    }
}
