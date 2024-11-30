namespace AbstractFactoryPattern.Banking.Products.Contas
{
    public abstract class Conta
    {
        public decimal SaldoAtual { get; set; }

        public abstract void Depositar(decimal valor);
        public abstract void Retirar(decimal valor);
        public abstract decimal Saldo();
    }
}
