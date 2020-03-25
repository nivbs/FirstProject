using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class TopBlock : ComponentBase
    {
        private Button ImageButton => new Button(Driver, ParentElement.FindElement(By.CssSelector(".product_img_link")));
        private Button QuickViewMobileButton => new Button(Driver, ParentElement.FindElement(By.CssSelector(".quick-view-mobile")));
        private Button QuickViewButton => new Button(Driver, ParentElement.FindElement(By.CssSelector(".quick-view")));
        public double Price => double.Parse(ParentElement.FindElement(By.CssSelector(".price")).Text.Replace("$", string.Empty));

        public TopBlock(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        //change to itemPage
        public BasePage ImageClick()
            => ImageButton.Click<BasePage>();

        //change to bigItem
        public ComponentBase QuickViewMobileClick()
            => QuickViewMobileButton.Click<ComponentBase>();

        //change to BigItem
        public ComponentBase QuickViewClick()
            => QuickViewButton.Click<ComponentBase>();

    }
}
