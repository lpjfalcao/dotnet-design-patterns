using AbstractFactoryPattern.Banking.Products.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Banking.Strategies
{
    public interface ITransacaoStrategy
    {
        void Depositar(decimal valor, Conta conta);
        void Retirar(decimal valor, Conta conta);
        decimal Saldo(Conta conta);
    }
}
