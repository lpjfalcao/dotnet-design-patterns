using Builder.Notifications.Buikders;
using Builder.Notifications.Products;

namespace Builder.Notifications
{
    public class Director
    {
        public static Email Construct(IEmailBuilder builder)
        {
            return builder
                .De("remetente@gmail.com")
                .Para("destinatario@email.com")
                .ComCopia("comcopia1@email.com", "comcopia2@email.com")
                .Assunto("Mensagem de teste")
                .Mensagem("Olá mundo! Estou usando o Padrão Builder :)")
                .Build();
        }
    }
}
