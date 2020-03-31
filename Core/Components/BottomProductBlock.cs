using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Infrastructure.BaseClasses;
using Infrastructure.Extensions;

namespace Infrastructure.Components
{
    public class BottomProductBlock : ComponentBase
    {
        public string ProductName => ParentElement.FindElement(".product-name").Text;
        public ProductButtonsContainer ItemButtonsContainer => new ProductButtonsContainer(Driver, ParentElement.FindElement(".button-container"));
        public IEnumerable<ColorButton> ColorsButtons => ParentElement.FindElements(".color_pick").Select(element => new ColorButton(Driver, element));

        public BottomProductBlock(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }
    }
}
