using System.Collections.Generic;
using OpenQA.Selenium;
using System.Linq;
using Infrastructure.Extensions;
using Infrastructure.BaseClasses;
using Infrastructure.Common;

namespace Infrastructure.Components
{
    public class ProductInfoInProductPage : ComponentBase
    {
        public IEnumerable<ColorButton> ColorButtons => ParentElement.FindElements("#color_to_pick_list li a").Select(element => new ColorButton(Driver, element));
        public string ProductName => ParentElement.FindElement(".pb-center-column h1").Text;
        private Button SelectedColorButton => new Button(Driver, ParentElement.FindElement("li .selected"));

        public ProductInfoInProductPage(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public string GetSelectedColorStyle()
            => SelectedColorButton.GetValueByAttribute("style");
    }
}
