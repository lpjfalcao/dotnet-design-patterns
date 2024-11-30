using AbstractFactoryPattern.ToolKit.Products;
using AbstractFactoryPattern.ToolKit.Products.Linux;

namespace AbstractFactoryPattern.ToolKit.Factories.Linux
{
    public class LinuxToolKitFactory : ToolKitAbstractFactory
    {
        private static LinuxToolKitFactory _self = new LinuxToolKitFactory();

        private LinuxToolKitFactory()
        {
            
        }

        public static LinuxToolKitFactory GetInstance()
        {
            if (_self == null)
                return new LinuxToolKitFactory();

            return _self;
        }

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
