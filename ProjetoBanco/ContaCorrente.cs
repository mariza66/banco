using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ProjetoBanco;



public class ContaCorrente
{
    public string nome;
    public int agencia;
    public string conta;
    public double saldo;


    public void Depositar(double valor)
    {

        this.saldo += valor;

    }



    public bool Sacar(double valor)
    {
        if (this.saldo >= valor)
        {
            this.saldo -= valor;
            return true;

        }
        else
        {
            Console.WriteLine("Saldo" +
                "insuficiente para realizar o saque.");
            return false;
        }

    }

    public bool Saque(double valor)
    {
        if (this.saldo >= valor)
        {
            this.saldo -= valor;
            return true;

        }

        else
        {
            Console.WriteLine("Saldo" +
                "insuficiente para realizar o saque.");
            return false;

        }
    }





        public bool transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo >= valor) {
            this.saldo -= valor;
            contaDestino.saldo += valor;
                return true;
            }

            else
            {
            return false;


            }
        Console.WriteLine("não foi possivel realizar a tranferência. +" +
            "o saldo é insuficiente");
    }
           
    }






