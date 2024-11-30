using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Banking.Products.Transacoes
{
    public class RetiradaTransacao : ITransacao
    {
        public void Executar()
        {
            Console.WriteLine("Retirando...");
        }
    }
}
