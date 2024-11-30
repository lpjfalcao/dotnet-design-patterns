using AbstractFactory.ToolKit.Products;
using AbstractFactory.ToolKit.Products.Windows;

namespace AbstractFactory.ToolKit.Factories.Windows
{
    public class WindowsToolKitFactory : ToolKitAbstractFactory
    {
        public override Button CreateButton(string name)
        {
            return new ButtonWindows(name);
        }

        public override Menu CreateMenu(string title)
        {
            return new MenuWindows(title);
        }

        public override Window CreateWindow(double positionX, double positionY)
        {
            return new WindowWindows(positionX, positionY);
        }
    }
}
