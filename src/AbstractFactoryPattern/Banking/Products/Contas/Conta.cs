using AbstractFactoryPattern.Banking.Strategies;

namespace AbstractFactoryPattern.Banking.Products.Contas
{
    public abstract class Conta
    {
        protected ITransacaoStrategy TransacaoStrategy;

        public Conta(ITransacaoStrategy transacaoStrategy) => TransacaoStrategy = transacaoStrategy;
        
        public void SetStrategy(ITransacaoStrategy transacaoStrategy) => TransacaoStrategy = transacaoStrategy;

        public decimal SaldoAtual { get; set; }

        public abstract void Depositar(decimal valor);
        public abstract void Retirar(decimal valor);
        public abstract decimal Saldo();
    }
}
