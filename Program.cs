using System;
using ReviBank;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Boas vindas ao seu Banco");
        Conta conta01 = new Conta("Luciano", "559");
        //conta01.ExibirDados();
        Console.WriteLine(conta01);      
        conta01.Depositar(1000);
        Console.WriteLine(conta01);

        //conta01.ExibirDados();

        conta01.Sacar(2000);
        Console.WriteLine(conta01);

        //conta01.NumeroConta = "111";

        //conta01.ExibirDados();

        //Conta conta02 = new Conta("Lia", "212);
        //Console.WriteLine(conta02);



    }
}
