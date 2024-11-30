using AbstractFactoryPattern.Banking.Factories;
using AbstractFactoryPattern.Banking.Products.Contas;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBankingFactory factory = new PFBankingFactory();

            Conta contaCorrente = factory.CriarContaCorrente(2000M);
            Conta contaSalario = factory.CriarContaSalario(1500M);
            Conta contaPoupanca = factory.CriarContaPoupanca(3200M);

            contaCorrente.Depositar(255.25M);
            contaCorrente.Retirar(15.50M);
            decimal saldoContaCorrente = contaCorrente.Saldo();

            Console.WriteLine("Saldo da conta corrente: {0:C}", saldoContaCorrente);
            Console.WriteLine();

            contaSalario.Depositar(430.12M);
            contaSalario.Retirar(100.10M);
            decimal saldoContaSalario = contaSalario.Saldo();

            Console.WriteLine("Saldo da conta salário: {0:C}", saldoContaSalario);
            Console.WriteLine();

            contaPoupanca.Depositar(1000);
            contaPoupanca.Retirar(250.25M);
            decimal saldoContaPoupanca = contaPoupanca.Saldo();

            Console.WriteLine("Saldo da conta poupança: {0:C}", saldoContaPoupanca);
            Console.WriteLine();
        }
    }
}
