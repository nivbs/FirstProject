using OpenQA.Selenium;
using System.Linq;
using Infrastructure.BaseClasses;
using Infrastructure.Common;
using Infrastructure.Pages;
using Infrastructure.Extensions;

namespace Infrastructure.Components
{
    public class TopProductBlock : ComponentBase
    {
        private Button ImageButton => new Button(Driver, ParentElement.FindElement(".product_img_link"));
        private Button QuickViewMobileButton => new Button(Driver, ParentElement.FindElement(".quick-view-mobile"));
        private Button QuickViewButton => new Button(Driver, ParentElement.FindElement(".quick-view"));
        public double Price => double.Parse(ParentElement.FindElement(".price").Text.Replace("$", string.Empty));

        public TopProductBlock(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public ProductPage ImageClick()
            => ImageButton.ClickUntilElementExist<ProductPage>(CssSelectorsInDriver.ProductPage.First().Value);

    }
}
