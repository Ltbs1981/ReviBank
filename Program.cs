using System;
using ReviBank;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome do titular:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o número da conta:");
        string numeroConta = Console.ReadLine(); // Corrigido para string

        Conta conta01;
        Console.WriteLine("Deseja depositar um saldo inicial na conta? (1 para sim, 2 para não)");
        int acao = int.Parse(Console.ReadLine());

        if (acao == 1)
        {
            Console.WriteLine("Digite o Valor inicial:");
            double valorInicial = double.Parse(Console.ReadLine());
            conta01 = new Conta(nome, numeroConta, valorInicial);
            Console.WriteLine("***Conta criada com sucesso***");
        }
        else
        {
            conta01 = new Conta(nome, numeroConta);
            Console.WriteLine("***Conta criada com sucesso***");
        }

        while (acao != 4)
        {
            Console.WriteLine(conta01.ToString()); // Corrigido para exibir informações da conta
            Console.WriteLine("Escolha a sua operação:\n 1. Consultar saldo\n 2. Fazer um saque\n 3. Fazer um depósito\n 4. Sair");
            acao = int.Parse(Console.ReadLine());

            switch (acao)
            {
                case 1:
                    Console.WriteLine(conta01.ToString()); // Exibe informações da conta
                    break;
                case 2:
                    Console.WriteLine("Digite o valor do saque:");
                    double valor = double.Parse(Console.ReadLine());
                    conta01.Sacar(valor);

                    break;
                case 3:
                    Console.WriteLine("Digite o valor do depósito:");
                    valor = double.Parse(Console.ReadLine());
                    conta01.Depositar(valor);
                    Console.WriteLine("Depósito realizado.");
                    break;
                case 4:
                    Console.WriteLine("Obrigado! ");
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida");
                    break;
            }
        }
    }
}
