using AbstractFactoryPattern.Banking.Products.Contas;

namespace AbstractFactoryPattern.Banking.Factories
{
    public interface IBankingFactory
    {
        Conta CriarContaCorrente(decimal saldo);
        Conta CriarContaPoupanca(decimal saldo);
        Conta CriarContaSalario(decimal saldo);
    }
}
