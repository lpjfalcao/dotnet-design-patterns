using AbstractFactoryPattern.Banking.Products.Contas;
using AbstractFactoryPattern.Banking.Products.Contas.PF;

namespace AbstractFactoryPattern.Banking.Factories
{
    public class PFBankingFactory : IBankingFactory
    {
        public Conta CriarContaCorrente(decimal saldo)
        {
            return new ContaCorrentePF(saldo);
        }

        public Conta CriarContaPoupanca(decimal saldo)
        {
            return new ContaPoupancaPF(saldo);
        }

        public Conta CriarContaSalario(decimal saldo)
        {
            return new ContaSalarioPF(saldo);
        }
    }
}
