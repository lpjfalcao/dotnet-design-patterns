using AbstractFactory.ToolKit.Products;

namespace AbstractFactory.ToolKit.Products.Linux
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
