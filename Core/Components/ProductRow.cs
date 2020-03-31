using OpenQA.Selenium;
using Infrastructure.BaseClasses;
using Infrastructure.Common;
using Infrastructure.Extensions;
using Infrastructure.Pages;

namespace Infrastructure.Components
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
            => DeleteButton.ClickUntilElementIsNotExist<CartPage>(new ProductRow(Driver, ParentElement));
            //return DeleteButton.Click();
            //return (CartPage)Utils.FindElement.WaitUntilNotExist(ParentElement, DeleteButton.Click<CartPage>());
            //DefaultWait<IWebElement> defaultWait = new DefaultWait<IWebElement>(ParentElement);
            //defaultWait.Timeout = TimeSpan.FromSeconds(20);
            //var cartPage = DeleteButton.Click<CartPage>();
            //return defaultWait.Until<CartPage>(parentElement =>
            //{
            //    try
            //    {

            //        if(parentElement.Enabled)
            //        {
            //            return null;
            //        }
            //        else
            //        {
            //            return cartPage;
            //        }
            //    }
            //    catch(StaleElementReferenceException)
            //    {
            //        return cartPage;
            //    }
            //    catch(NoSuchElementException)
            //    {
            //        return cartPage;
            //    }
            //});
        
    }
}
