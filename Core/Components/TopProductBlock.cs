using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Linq;

namespace Infrastructure
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

        //change to itemPage
        public ProductPage ImageClick()
            => ImageButton.ClickUntilElementExist<ProductPage>(CssSelectorsInDriver.ProductPage.First().Value);

        //change to bigItem
       // public ComponentBase QuickViewMobileClick()
       //     => QuickViewMobileButton.Click<ComponentBase>();

        //change to BigItem
        //public ComponentBase QuickViewClick()
        //    => QuickViewButton.Click<ComponentBase>();

    }
}
