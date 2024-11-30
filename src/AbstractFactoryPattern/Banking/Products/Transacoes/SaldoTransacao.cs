using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Banking.Products.Transacoes
{
    public class SaldoTransacao : ITransacao
    {
        public void Executar()
        {
            Console.WriteLine("Atualizando Saldo...");
        }
    }
}
