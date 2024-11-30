using AbstractFactoryPattern.ToolKit.Factories.Linux;
using AbstractFactoryPattern.ToolKit.Factories;
using AbstractFactoryPattern.ToolKit.Products;
using AbstractFactoryPattern.Banking.Factories;
using AbstractFactoryPattern.Banking.Products.Contas;
using AbstractFactoryPattern.Banking.Products.Transacoes;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBankingFactory factory = new PFBankingFactory();

            IConta conta = factory.CriarConta();
            ITransacao transacao = factory.CriarTransacao();

            conta.Depositar(100);
            transacao.Executar();
        }
    }
}
