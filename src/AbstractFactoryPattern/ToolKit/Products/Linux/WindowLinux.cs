using AbstractFactoryPattern.ToolKit.Products;

namespace AbstractFactoryPattern.ToolKit.Products.Linux
{
    public class WindowLinux : Window
    {
        public WindowLinux(double x, double y)
        {
            PositionX = x;
            PositionY = y;
        }
    }
}
