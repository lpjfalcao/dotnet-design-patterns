using Builder.Notifications.Products;

namespace Builder.Notifications.Buikders
{
    public interface IEmailBuilder
    {
        IEmailBuilder De(string de);
        IEmailBuilder Para(params string[] para);
        IEmailBuilder ComCopia(params string[] comCopia);
        IEmailBuilder Mensagem(string mensagem);
        IEmailBuilder Assunto(string assunto);
        Email Build();
    }
}
