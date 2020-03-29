using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class Quantity : ComponentBase
    {
        public TextBox QuantityTextBox => new TextBox(Driver, ParentElement.FindElement("input:nth-of-type(2)"));
        private Button PlusButton => new Button(Driver, ParentElement.FindElement(".cart_quantity_up"));
        private Button MinusButton => new Button(Driver, ParentElement.FindElement(".cart_quantity_down"));
        
        public Quantity(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public CartPage PlusClick()
            => Utils.FindElement.WaitUntilClickChangeId<CartPage>(PlusButton);

        public CartPage MinusClick()
            => Utils.FindElement.WaitUntilClickChangeId<CartPage>(MinusButton);
    }
}
