using System;

namespace ReviBank
{
    public class ContaPrime : Conta
    {
        public int PontosEmMilhas { get; set; }
        public double ChequeEspecial { get; set; }

        public ContaPrime(string nome, string numeroConta, int pontosEmMilhas) : base(nome, numeroConta)
        {
            PontosEmMilhas = pontosEmMilhas;
            ChequeEspecial = 1000; // Exemplo de limite de cheque especial
        }

        public ContaPrime(string nome, string numeroConta, double saldo, int pontosEmMilhas) : base(nome, numeroConta, saldo)
        {
            PontosEmMilhas = pontosEmMilhas;
            ChequeEspecial = 1000; // Exemplo de limite de cheque especial
        }

        public override string ToString()
        {
            return $"Titular: {Nome}\t Conta: {NumeroConta}\t Saldo: {Saldo:F2}\t Milhas: {PontosEmMilhas}\t Cheque Especial: {ChequeEspecial:F2}";
        }
    }
}
