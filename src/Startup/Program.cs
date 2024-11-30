using AbstractFactory.ToolKit.Factories;
using AbstractFactory.ToolKit.Factories.Linux;
using AbstractFactory.ToolKit.Products;

ToolKitAbstractFactory factory = new LinuxToolKitFactory();

Button linuxButton = factory.CreateButton("Eu sou um botão no estilo do Linux");
Window linuxWindow = factory.CreateWindow(100, 100);
Menu linuxMenu = factory.CreateMenu("Eu sou um menu no estilo do Linux");

Console.WriteLine("Nome do botão: {0}", linuxButton.Name);
Console.WriteLine("Janela na posição X: {0} e Y: {1}", linuxWindow.PositionX, linuxWindow.PositionY);
Console.WriteLine("Título do menu: {0}", linuxMenu.Title);
  