using System;
using System.Globalization;
using Encapsulamento;

class Program {
    public static void Main(string[] args) {
    
        ContaBancaria conta;

        Console.WriteLine("Informe os dados da conta:");

        Console.Write("Entre com o número da conta: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Entre com o titular da conta: ");
        string titular = Console.ReadLine();

        Console.Write("Haverá depósito inicial (s/n)? ");
        char resposta = Console.ReadLine()[0];
        if (resposta == 's' || resposta == 'S') {
            Console.Write("Entre com um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta = new ContaBancaria(numero, titular, deposito);
        } else {
            conta = new ContaBancaria(numero, titular);
        }

        Console.WriteLine(conta);
    }
}