namespace AbstractFactoryPattern.Banking.Products.Contas
{
    public interface IConta
    {
        void Depositar(decimal valor);
        void Retirar(decimal valor);
        decimal Saldo();
    }
}
