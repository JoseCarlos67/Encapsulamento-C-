using System;
using System.Globalization;
using Encapsulamento;

class Program {
    public static void Main(string[] args) {
    
        ContaBancaria conta;

        Console.Write("Entre com o número da conta: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Entre com o titular da conta: ");
        string titular = Console.ReadLine();

        Console.Write("Haverá depósito inicial (s/n)? ");
        char resposta = Console.ReadLine()[0];
        double quantia;
        if (resposta == 's' || resposta == 'S') {
            Console.Write("Entre com um valor para depósito: ");
            quantia = double.Parse(Console.ReadLine());

            conta = new ContaBancaria(numero, titular, quantia);
        } else {
            conta = new ContaBancaria(numero, titular);
        }

        Console.WriteLine("\n"+conta);

        Console.Write("\nEntre com um valor para depósito: ");
        quantia = double.Parse(Console.ReadLine());
        conta.Deposito(quantia);
        Console.WriteLine("\nDados atualizados: ");
        Console.WriteLine(conta);

        Console.Write("\nEntre com um valor para saque: ");
        quantia = double.Parse(Console.ReadLine());
        conta.Saque(quantia);
        Console.WriteLine("\nDados atualizados: ");
        Console.WriteLine(conta);
        
    }
}