using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class Program
    {
        static void Main(string[] args)
        {


            ContaCorrente conta1= new ContaCorrente();
            conta1.agencia = 56;
            conta1.conta = "123456-x";
            conta1.nome = "Claudio";
            

            Console.WriteLine(conta1.nome);
            Console.WriteLine(conta1.agencia);
            Console.WriteLine(conta1.conta);

            conta1.saldo = 456.00;
            Console.WriteLine("O saldo anterior é:R$" + conta1.saldo);
            conta1.Depositar(300);   
            Console.WriteLine("o saldo da conta é: R$ "+conta1.saldo);

            


            ContaCorrente conta2 = new ContaCorrente();
            conta2.agencia = 36;
            conta2.conta = "4561";
            conta2.nome = "Luiz";
            conta2.saldo = 600;
                Console.WriteLine("saldo antigo:R$" + conta2.saldo);
                conta2.Sacar(200);
                Console.WriteLine("valor atual saldo:R$" + conta2.saldo);








        }
    }
}
