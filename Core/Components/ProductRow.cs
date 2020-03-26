﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class ProductRow : ComponentBase
    {
        public ProductDescription ProductDescription => new ProductDescription(Driver, ParentElement.FindElement(".cart_description"));
        public double UnitPrice => double.Parse(ParentElement.FindElement(".price .price").Text.Replace("$", string.Empty));
        public Quantity Quantity => new Quantity(Driver, ParentElement.FindElement(".cart_quantity"));
        public double TotalPrice => double.Parse(ParentElement.FindElement(".cart_total .price").Text.Replace("$", string.Empty));
        private Button DeleteButton => new Button(Driver, ParentElement.FindElement(".cart_quantity_delete"));

        public ProductRow(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public CartPage DeleteClick()
            => DeleteButton.Click<CartPage>();
    }
}
