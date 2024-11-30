using AbstractFactoryPattern.ToolKit.Products;

namespace AbstractFactoryPattern.ToolKit.Factories
{
    public abstract class ToolKitAbstractFactory
    {
        public abstract Button CreateButton(string name);
        public abstract Menu CreateMenu(string title);
        public abstract Window CreateWindow(double positionX, double positionY);
    }
}
