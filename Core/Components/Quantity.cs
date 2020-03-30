using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class Quantity : ComponentBase
    {
        private TextBox QuantityTextBox => new TextBox(Driver, ParentElement.FindElement("input:nth-of-type(2)"));
        private Button PlusButton => new Button(Driver, ParentElement.FindElement(".cart_quantity_up"));
        private Button MinusButton => new Button(Driver, ParentElement.FindElement(".cart_quantity_down"));
        
        public Quantity(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public CartPage PlusClick()
        //=> Utils.FindElement.WaitUntilClickRefreshed<CartPage>(PlusButton);
        //{
        //    int quantity = (int)GetQuantity();
        //    var cartPage = PlusButton.Click<CartPage>();
        //    QuantityTextBox.WaitUntilAttributeEquals("value", (quantity + 1).ToString());

        //    return cartPage;
        //}
            => PlusButton.ClickUntilComponentChangeValue<CartPage>(QuantityTextBox, "value", (((int)GetQuantity()) + 1).ToString());


        public CartPage MinusClick()
        //=> Utils.FindElement.WaitUntilClickChangeId<CartPage>(MinusButton);
        //{
        //    int quantity = (int)GetQuantity();
        //    var cartPage = MinusButton.Click<CartPage>();
        //    QuantityTextBox.WaitUntilAttributeEquals("value", (quantity - 1).ToString());

        //    return cartPage;
        //}
        => PlusButton.ClickUntilComponentChangeValue<CartPage>(QuantityTextBox, "value", (((int)GetQuantity()) - 1).ToString());

        public void FillQuantity(string value)
            => QuantityTextBox.FillNewValue(value);

        public double GetQuantity()
            => double.Parse(QuantityTextBox.GetValueByAttribute("value"));
    }
}
