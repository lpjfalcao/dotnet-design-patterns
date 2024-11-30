using AbstractFactoryPattern.Banking.Products.Contas;
using AbstractFactoryPattern.Banking.Products.Transacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Banking.Factories
{
    public class PJBankingFactory : IBankingFactory
    {
        public IConta CriarConta() => new ContaPoupanca();

        public ITransacao CriarTransacao() => new RetiradaTransacao();        
    }
}
