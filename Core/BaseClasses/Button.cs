using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Infrastructure
{
    public class Button : ComponentBase
    {
        public Button(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {
            
        }

        public T Click<T>(KeyValuePair<ISearchContext, string> keyValuePair = new KeyValuePair<ISearchContext, string>(),
             string cssSelectorFromDriver = "")
             where T:DriverUser
        {
            ParentElement.Click();
            //if (cssSelectorFromDriver != "")
            //{
            //    WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            //    wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            //    wait.Until<bool>(ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector(cssSelectorFromDriver)));
            //}

            if (keyValuePair.Value == null && keyValuePair.Key == null)
            {
                return (T)Activator.CreateInstance(typeof(T), Driver);
            }
            else
            {
                return (T)Activator.CreateInstance(typeof(T), Driver, keyValuePair.Key.FindElement(keyValuePair.Value));
            }
        }

        public string GetText()
            => ParentElement.Text;

        public string GetLink()
            => GetValueByAttribute("href");
    }
}
