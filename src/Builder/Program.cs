using Builder.Notifications;
using Builder.Notifications.Buikders;
using Builder.Notifications.Products;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Email email = Director.Construct(new EmailBuilder());

            Console.WriteLine("Remetente: {0}", email.De);

            Console.WriteLine("Destinatário...");
            foreach (var destinatario in email.Para)
            {
                Console.WriteLine(destinatario);
            }

            Console.WriteLine();

            Console.WriteLine("Com cópia para...");
            foreach (var copia in email.ComCopia)
            {
                Console.WriteLine(copia);
            }

            Console.WriteLine();

            Console.WriteLine("Assunto: {0}", email.Assunto);
            Console.WriteLine("Mensagem: {0}", email.Mensagem);
        }
    }
}
