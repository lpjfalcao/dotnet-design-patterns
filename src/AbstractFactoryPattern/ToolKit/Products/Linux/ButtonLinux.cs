using AbstractFactoryPattern.ToolKit.Products;

namespace AbstractFactoryPattern.ToolKit.Products.Linux
{
    public class ButtonLinux : Button
    {
        public ButtonLinux(string name) 
        {
            Name = name;
        }
    }
}
