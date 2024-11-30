using AbstractFactoryPattern.Banking.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Banking.Products.Contas.PF
{
    public class ContaPoupancaPF : Conta
    {
        public ContaPoupancaPF(decimal saldo) : base(new TransacaoGenericaStrategy())
        {
            SaldoAtual = saldo;
        }

        public override void Depositar(decimal valor)
        {
            TransacaoStrategy.Depositar(valor, this);
        }

        public override void Retirar(decimal valor)
        {
            TransacaoStrategy.Retirar(valor, this);
        }

        public override decimal Saldo()
        {
            return TransacaoStrategy.Saldo(this);
        }
    }
}
