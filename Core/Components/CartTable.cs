using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class CartTable : ComponentBase
    {
        public IEnumerable<ProductRow> ProductRows => ParentElement.FindElements(By.CssSelector("tbody tr")).Select(element => new ProductRow(Driver, element));
        public double TotalProductsPrice => double.Parse(ParentElement.FindElement(By.CssSelector("#total_product")).Text.Replace("$", string.Empty));
        public double TotalShippingPrice => double.Parse(ParentElement.FindElement(By.CssSelector("#total_shipping")).Text.Replace("$", string.Empty));
        public double TotalPriceWithoutTax=> double.Parse(ParentElement.FindElement(By.CssSelector("#total_price_without_tax")).Text.Replace("$", string.Empty));
        public double TaxPrice => double.Parse(ParentElement.FindElement(By.CssSelector("#total_tax")).Text.Replace("$", string.Empty));
        public double TotalPrice => double.Parse(ParentElement.FindElement(By.CssSelector("#total_price")).Text.Replace("$", string.Empty));

        public CartTable(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }
    }
}
