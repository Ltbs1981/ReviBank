using System;
using ReviBank;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Boas vindas ao seu Banco");
        Conta conta01 = new Conta("Luciano", "559",1000);
        conta01.ExibirDados();
        
        conta01.Depositar(1000);

        conta01.ExibirDados();

        conta01.Sacar(2000);

        //conta01.NumeroConta = "111";

        conta01.ExibirDados();


    }
}
