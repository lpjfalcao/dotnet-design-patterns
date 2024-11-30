using AbstractFactoryPattern.ToolKit.Products;
using AbstractFactoryPattern.ToolKit.Products.Mac;

namespace AbstractFactoryPattern.ToolKit.Factories.Mac
{
    public class MacToolKitFactory : ToolKitAbstractFactory
    {
        public override Button CreateButton(string name)
        {
            return new ButtonMac(name);
        }

        public override Menu CreateMenu(string title)
        {
            return new MenuMac(title);
        }

        public override Window CreateWindow(double positionX, double positionY)
        {
            return new WindowMac(positionX, positionY);
        }
    }
}
