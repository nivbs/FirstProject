using OpenQA.Selenium;
using Infrastructure.BaseClasses;
using Infrastructure.Extensions;

namespace Infrastructure.Components
{
    public class Product : ComponentBase
    {
        public TopProductBlock TopBlock => new TopProductBlock(Driver, ParentElement.FindElement(".left-block"));
        public BottomProductBlock BottomBlock => new BottomProductBlock(Driver, ParentElement.FindElement(".right-block"));

        public Product(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }
    }
}
