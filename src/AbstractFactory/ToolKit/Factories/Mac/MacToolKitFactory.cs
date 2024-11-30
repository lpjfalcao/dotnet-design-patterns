using AbstractFactory.ToolKit.Products;
using AbstractFactory.ToolKit.Products.Mac;

namespace AbstractFactory.ToolKit.Factories.Mac
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
