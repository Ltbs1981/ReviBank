using System;
using ReviBank;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Boas vindas ao seu Banco");
        Conta conta01 = new Conta("Luciano", "559", 50000);
        conta01.ExibirDados();
        double depositando = 5000;
        conta01.Depositar(depositando);

        conta01.ExibirDados();

        conta01.Sacar(55000);

        conta01.ExibirDados();


    }
}
