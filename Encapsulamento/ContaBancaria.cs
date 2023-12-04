using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private int _numero;
        private string _titular;
        private double _saldo;


        public ContaBancaria(int numero, string titular){
            _numero = numero;
            _titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular) {
            _saldo = saldo;
        }

        public void Deposito(double quantia) {
            _saldo += quantia;
        }

        public void Saque(double quantia) {
            _saldo -= quantia + 5;
        }

        public override string ToString()
        {
            return "Conta "
            + _numero
            + ", Titular: "
            + _titular
            + ", Saldo: $"
            + _saldo.ToString("F2");
        }
    }
}