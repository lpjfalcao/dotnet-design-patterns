using AbstractFactoryPattern.Banking.Strategies;

namespace AbstractFactoryPattern.Banking.Products.Contas
{
    public class ContaSalarioPJ : Conta
    {
        public ContaSalarioPJ(decimal saldo) : base(new TransacaoGenericaStrategy())
        {
            SaldoAtual = saldo;
        }

        public override void Depositar(decimal valor)
        {
            TransacaoStrategy.Depositar(valor, this);
        }

        public override void Retirar(decimal valor)
        {
            TransacaoStrategy.Retirar(valor, this);
        }

        public override decimal Saldo()
        {
            return TransacaoStrategy.Saldo(this);
        }
    }
}
