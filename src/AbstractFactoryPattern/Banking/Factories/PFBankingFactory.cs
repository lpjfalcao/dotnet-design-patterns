using AbstractFactoryPattern.Banking.Products.Contas;
using AbstractFactoryPattern.Banking.Products.Transacoes;

namespace AbstractFactoryPattern.Banking.Factories
{
    public class PFBankingFactory : IBankingFactory
    {
        public IConta CriarConta() => new ContaCorrente();

        public ITransacao CriarTransacao() => new DepositoTransacao();
        
    }
}
