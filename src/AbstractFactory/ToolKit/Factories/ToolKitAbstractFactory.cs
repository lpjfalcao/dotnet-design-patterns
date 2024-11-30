using AbstractFactory.ToolKit.Products;

namespace AbstractFactory.ToolKit.Factories
{
    public abstract class ToolKitAbstractFactory
    {
        public abstract Button CreateButton(string name);
        public abstract Menu CreateMenu(string title);
        public abstract Window CreateWindow(double positionX, double positionY);
    }
}
