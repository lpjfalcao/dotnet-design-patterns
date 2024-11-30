using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Banking.Products.Contas.PF
{
    public class ContaPoupancaPF : Conta
    {
        public ContaPoupancaPF(decimal saldo)
        {
            SaldoAtual = saldo;
        }

        public override void Depositar(decimal valor)
        {
            Console.WriteLine("Depositando {0:C}", valor);
            SaldoAtual += valor;
        }

        public override void Retirar(decimal valor)
        {
            Console.WriteLine("Retirando {0:C}", valor);
            SaldoAtual -= valor;
        }

        public override decimal Saldo()
        {
            Console.WriteLine("Recuperando saldo...");
            return SaldoAtual;
        }
    }
}
