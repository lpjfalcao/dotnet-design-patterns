using Builder.Notifications.Products;

namespace Builder.Notifications.Buikders
{
    public class EmailBuilder : IEmailBuilder
    {
        private readonly Email email = new();

        public IEmailBuilder Assunto(string assunto)
        {
            email.Assunto = assunto;

            return this;
        }

        public IEmailBuilder ComCopia(params string[] comCopia)
        {
            email.ComCopia = comCopia.ToList();

            return this;
        }

        public IEmailBuilder De(string de)
        {
            email.De = de;

            return this;
        }

        public IEmailBuilder Mensagem(string mensagem)
        {
            email.Mensagem = mensagem;

            return this;
        }

        public IEmailBuilder Para(params string[] para)
        {
            email.Para = para.ToList();

            return this;
        }

        public Email Build()
        {
            return email;
        }
    }
}
