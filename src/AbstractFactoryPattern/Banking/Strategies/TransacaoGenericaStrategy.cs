using AbstractFactoryPattern.Banking.Products.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Banking.Strategies
{
    public class TransacaoGenericaStrategy : ITransacaoStrategy
    {
        public void Depositar(decimal valor, Conta conta)
        {
            Console.WriteLine("Depositando {0:C}", valor);
            conta.SaldoAtual += valor;
        }

        public void Retirar(decimal valor, Conta conta)
        {
            Console.WriteLine("Retirando {0:C}", valor);
            conta.SaldoAtual -= valor;
        }

        public decimal Saldo(Conta conta)
        {
            Console.WriteLine("Recuperando saldo...");
            return conta.SaldoAtual;
        }
    }
}
