using AbstractFactoryPattern.Banking.Products.Contas;

namespace AbstractFactoryPattern.Banking.Factories
{
    public class PJBankingFactory : IBankingFactory
    {
        public Conta CriarContaCorrente(decimal saldo)
        {
            return new ContaCorrentePJ(saldo);
        }

        public Conta CriarContaPoupanca(decimal saldo)
        {
            return new ContaPoupancaPJ(saldo);
        }

        public Conta CriarContaSalario(decimal saldo)
        {
            return new ContaSalarioPJ(saldo);
        }
    }
}
