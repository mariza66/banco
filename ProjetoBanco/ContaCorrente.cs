﻿using System;
using System.Collections.Generic;
using System.Linq;
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



    public void Sacar(double valor)
    {
        this.saldo -= valor;
    }



}

    

