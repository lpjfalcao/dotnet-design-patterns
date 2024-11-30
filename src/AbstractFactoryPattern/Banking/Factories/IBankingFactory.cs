using AbstractFactoryPattern.Banking.Products.Contas;
using AbstractFactoryPattern.Banking.Products.Transacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Banking.Factories
{
    public interface IBankingFactory
    {
        IConta CriarConta();
        ITransacao CriarTransacao();
    }
}
