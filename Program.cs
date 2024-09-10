using System;
using ReviBank;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome do titular:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o número da conta:");
        string numeroConta = Console.ReadLine();

        Conta conta;

        Console.WriteLine("Escolha o tipo de conta:\n 1. Conta Normal\n 2. Conta Salário\n 3. Conta Prime");
        int tipoConta = int.Parse(Console.ReadLine());

        Console.WriteLine("Deseja depositar um saldo inicial na conta? (1 para sim, 2 para não)");
        int acao = int.Parse(Console.ReadLine());

        double saldoInicial = 0;
        if (acao == 1)
        {
            Console.WriteLine("Digite o valor inicial:");
            saldoInicial = double.Parse(Console.ReadLine());
        }

        switch (tipoConta)
        {
            case 1:
                conta = acao == 1 ? new Conta(nome, numeroConta, saldoInicial) : new Conta(nome, numeroConta);
                break;
            case 2:
                Console.WriteLine("Digite o nome da empresa:");
                string nomeEmpresa = Console.ReadLine();
                conta = acao == 1 ? new ContaSalario(nome, numeroConta, saldoInicial, nomeEmpresa) : new ContaSalario(nome, numeroConta, nomeEmpresa);
                break;
            case 3:
                Console.WriteLine("Digite os pontos em milhas:");
                int pontosMilhas = int.Parse(Console.ReadLine());
                conta = acao == 1 ? new ContaPrime(nome, numeroConta, saldoInicial, pontosMilhas) : new ContaPrime(nome, numeroConta, pontosMilhas);
                break;
            default:
                conta = new Conta(nome, numeroConta); 
                Console.WriteLine("-Conta criada com sucesso-");
                break;
        }

        Console.WriteLine("-Conta criada com sucesso-");

        while (acao != 4)
        {
            Console.WriteLine(conta.ToString());
            Console.WriteLine("Escolha a sua operação:\n 1. Consultar saldo\n 2. Fazer um saque\n 3. Fazer um depósito\n 4. Sair");
            acao = int.Parse(Console.ReadLine());

            switch (acao)
            {
                case 1:
                    Console.WriteLine(conta.ToString());
                    break;
                case 2:
                    Console.WriteLine("Digite o valor do saque:");
                    double valorSaque = double.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    break;
                case 3:
                    Console.WriteLine("Digite o valor do depósito:");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    Console.WriteLine("Depósito realizado.");
                    break;
                case 4:
                    Console.WriteLine("Obrigado!");
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida.");
                    break;
            }
        }
    }
}
