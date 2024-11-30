using AbstractFactoryPattern.ToolKit.Products;
using AbstractFactoryPattern.ToolKit.Products.Linux;

namespace AbstractFactoryPattern.ToolKit.Factories.Linux
{
    public class LinuxToolKitFactory : ToolKitAbstractFactory
    {
        public override Button CreateButton(string name)
        {
            return new ButtonLinux(name);
        }

        public override Menu CreateMenu(string title)
        {
            return new MenuLinux(title);
        }

        public override Window CreateWindow(double positionX, double positionY)
        {
            return new WindowLinux(positionX, positionY);
        }
    }
}
