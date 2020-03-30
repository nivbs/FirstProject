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

        protected T Click<T>(KeyValuePair<ISearchContext, string> keyValuePair = new KeyValuePair<ISearchContext, string>())
             where T:DriverUser
        {
            ParentElement.Click();

            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            //wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            //wait.Until(ExpectedConditions.ElementToBeClickable(ParentElement));

            if (keyValuePair.Value == null && keyValuePair.Key == null)
            {
                return (T)Activator.CreateInstance(typeof(T), Driver);
            }
            else
            {
                return (T)Activator.CreateInstance(typeof(T), Driver, keyValuePair.Key.FindElement(keyValuePair.Value));
            }
        }

        public T ClickUntilComponentChangeValue<T>(ComponentBase component, string attribute, string expectedValue, int seconds = 20
            , KeyValuePair<ISearchContext, string> keyValuePair = new KeyValuePair<ISearchContext, string>())
             where T : DriverUser
        {
            T driverUser = Click<T>(keyValuePair);
            component.WaitUntilAttributeEquals(attribute, expectedValue, seconds);

            return driverUser;
        }

        public T ClickUntilElementExist<T>(string cssSelectorInDriver,
            KeyValuePair<ISearchContext, string> keyValuePair = new KeyValuePair<ISearchContext, string>())
             where T : DriverUser
        {
            T driverUser = Click<T>(keyValuePair);
            Driver.FindElement(cssSelectorInDriver);

            return driverUser;
        }

        public T ClickUntilElementIsNotExist<T>(ComponentBase component, KeyValuePair<ISearchContext, string> keyValuePair = new KeyValuePair<ISearchContext, string>())
             where T : DriverUser
        {
            T driverUser = Click<T>(keyValuePair);
            DefaultWait<ComponentBase> defaultWait = new DefaultWait<ComponentBase>(component);
            defaultWait.Timeout = TimeSpan.FromSeconds(20);

            return defaultWait.Until<T>(myComponent =>
            {
                try
                {
                    if (myComponent.IsEnabled())
                    {
                        return null;
                    }

                    return driverUser;
                }
                catch (StaleElementReferenceException)
                {
                    return driverUser;
                }
                catch (NoSuchElementException)
                {
                    return driverUser;
                }
            });
        }

        public string GetText()
            => ParentElement.Text;

        public string GetLink()
            => GetValueByAttribute("href");
    }
}
