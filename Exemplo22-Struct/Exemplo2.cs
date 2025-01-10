using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo22_Struct
{
    public struct ContaBancariaStruct
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public ContaBancariaStruct(string numero, string titular,
        decimal saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Deposito(decimal valor)
        {
            Saldo += valor;
        }

        public void Saque(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente"); 
            }
        }

        public void AlterarSaldo(decimal valor)
        {
            this = new ContaBancariaStruct(this.Numero, this.Titular, valor + Saldo );
            System.Console.WriteLine("Saldo alterado com sucesso");
        }

        public override string ToString() 
        {
            return $"Numero: {Numero}, Titular: {Titular}, Saldo: {Saldo}";
        }
    }


    public class ContaBancariaClass
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public ContaBancariaClass(string numero, string titular,
        decimal saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Deposito(decimal valor)
        {
            Saldo += valor;
        }

        public void Saque(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente"); 
            }
        }

        public void AlterarSaldo(decimal valor)
        {
            Saldo = valor + Saldo;
            System.Console.WriteLine("Saldo alterado com sucesso");
        }
        public override string ToString() 
        {
            return $"Numero: {Numero}, Titular: {Titular}, Saldo: {Saldo}";
        }
    }

    class Executar333{
        static void Main(string[] args)
        {
            ContaBancariaStruct conta1 = new ContaBancariaStruct("123", "Willdanthe", 1000.00m);

            conta1.AlterarSaldo(5000.00m);
            conta1.Deposito(1000.00m);

            System.Console.WriteLine(conta1);


            ContaBancariaClass conta2 = new ContaBancariaClass("123", "Uiuidanthe", 1000.00m);

            conta2.AlterarSaldo(5000.00m);
            System.Console.WriteLine(conta2);
        }
    }
}