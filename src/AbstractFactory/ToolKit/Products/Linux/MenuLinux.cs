using AbstractFactory.ToolKit.Products;

namespace AbstractFactory.ToolKit.Products.Linux
{
    public class MenuLinux : Menu
    {
        public MenuLinux(string title)
        {
            Title = title;
        }
    }
}
