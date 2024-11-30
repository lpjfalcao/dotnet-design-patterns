namespace AbstractFactoryPattern.Banking.Products.Contas
{
    public class ContaSalario : IConta
    {
        public void Depositar(decimal valor)
        {
            Console.WriteLine("Depositando {0:C}", valor);
        }

        public void Retirar(decimal valor)
        {
            Console.WriteLine("Retirando {0:C}", valor);
        }

        public decimal Saldo()
        {
            Console.WriteLine("Recuperando saldo...");
            return 1255.32M;
        }
    }
}
