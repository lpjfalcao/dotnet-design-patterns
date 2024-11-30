using AbstractFactoryPattern.ToolKit.Products;

namespace AbstractFactoryPattern.ToolKit.Products.Linux
{
    public class MenuLinux : Menu
    {
        public MenuLinux(string title)
        {
            Title = title;
        }
    }
}
