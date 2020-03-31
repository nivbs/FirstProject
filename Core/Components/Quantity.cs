﻿using System;
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
            => PlusButton.ClickUntilComponentChangeValue<CartPage>(QuantityTextBox, "value", (((int)GetQuantity()) + 1).ToString());


        public CartPage MinusClick()
            => PlusButton.ClickUntilComponentChangeValue<CartPage>(QuantityTextBox, "value", (((int)GetQuantity()) - 1).ToString());

        public void FillQuantity(string value)
            => QuantityTextBox.FillNewValue(value);

        public double GetQuantity()
            => double.Parse(QuantityTextBox.GetValueByAttribute("value"));
    }
}
