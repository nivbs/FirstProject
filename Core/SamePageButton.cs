using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Infrastructure
{
    public class SamePageButton<T>:Button
        where T:DriverUser 
    {
        public SamePageButton(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public T Click(KeyValuePair<ISearchContext, string> keyValuePair = new KeyValuePair<ISearchContext, string>())
        {
            //DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(ParentElement);
            //wait.Timeout = TimeSpan.FromSeconds(20);
            //wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            //ParentElement.Click();
            //wait.Until(button =>
            //{
            //    if(button.Enabled)
            //    {
            //        return button;
            //    }

            //    return null;
            //});

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(ExpectedConditions.ElementToBeClickable(ParentElement));

            if (keyValuePair.Value == null && keyValuePair.Key == null)
            {
                return (T)Activator.CreateInstance(typeof(T), Driver);
            }
            else
            {
                return (T)Activator.CreateInstance(typeof(T), Driver, keyValuePair.Key.FindElement(keyValuePair.Value));
            }
        }
    }
}
