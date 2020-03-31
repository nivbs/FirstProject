using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Linq;
using Infrastructure.BaseClasses;
using Infrastructure.Extensions;

namespace Infrastructure.Components
{
    public class ViewedProducts : ComponentBase
    {
        public IEnumerable<ViewedProductInfo> ViewedProductInfos => ParentElement.FindElements(".products-block li").Select(element => new ViewedProductInfo(Driver, element));

        public ViewedProducts(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }
    }
}
