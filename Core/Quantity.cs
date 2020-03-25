using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Core
{
    public class Quantity : ComponentBase
    {
        public TextBox QuantityTextBox => new TextBox(Driver, ParentElement.FindElement(By.CssSelector("input:nth-of-type(1)")));
        private Button PlusButton => new Button(Driver, ParentElement.FindElement(By.CssSelector(".cart_quantity_up")));
        private Button MinusButton => new Button(Driver, ParentElement.FindElement(By.CssSelector(".cart_quantity_down")));
        
        public Quantity(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        //change to cartPage
        public BasePage PlusClick()
            => PlusButton.Click<BasePage>();

        //change to cartPage
        public BasePage MinusClick()
            => MinusButton.Click<BasePage>();
    }
}
