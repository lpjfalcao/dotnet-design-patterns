using AbstractFactoryPattern.ToolKit.Products;

namespace AbstractFactoryPattern.ToolKit.Products.Mac
{
    public class WindowMac : Window
    {
        public WindowMac(double x, double y)
        {
            PositionX = x;
            PositionY = y;
        }
    }
}
