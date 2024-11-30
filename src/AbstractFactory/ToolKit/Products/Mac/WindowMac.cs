using AbstractFactory.ToolKit.Products;

namespace AbstractFactory.ToolKit.Products.Mac
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
