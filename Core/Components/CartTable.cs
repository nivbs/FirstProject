using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Infrastructure.BaseClasses;
using Infrastructure.Extensions;

namespace Infrastructure.Components
{
    public class CartTable : ComponentBase
    {
        public IEnumerable<ProductRow> ProductRows => ParentElement.FindElements("tbody tr").Select(element => new ProductRow(Driver, element));
        public double TotalProductsPrice => double.Parse(ParentElement.FindElement("#total_product").Text.Replace("$", string.Empty));
        public double TotalShippingPrice => double.Parse(ParentElement.FindElement("#total_shipping").Text.Replace("$", string.Empty));
        public double TotalPriceWithoutTax=> double.Parse(ParentElement.FindElement("#total_price_without_tax").Text.Replace("$", string.Empty));
        public double TaxPrice => double.Parse(ParentElement.FindElement("#total_tax").Text.Replace("$", string.Empty));
        public double TotalPrice => double.Parse(ParentElement.FindElement("#total_price").Text.Replace("$", string.Empty));

        public CartTable(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }
    }
}
