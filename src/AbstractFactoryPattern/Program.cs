using AbstractFactoryPattern.ToolKit.Factories.Linux;
using AbstractFactoryPattern.ToolKit.Factories;
using AbstractFactoryPattern.ToolKit.Products;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToolKitAbstractFactory factory = LinuxToolKitFactory.GetInstance();

            Button linuxButton = factory.CreateButton("Eu sou um botão no estilo do Linux");
            Window linuxWindow = factory.CreateWindow(100, 100);
            Menu linuxMenu = factory.CreateMenu("Eu sou um menu no estilo do Linux");

            Console.WriteLine("Nome do botão: {0}", linuxButton.Name);
            Console.WriteLine("Janela na posição X: {0} e Y: {1}", linuxWindow.PositionX, linuxWindow.PositionY);
            Console.WriteLine("Título do menu: {0}", linuxMenu.Title);
        }
    }
}
