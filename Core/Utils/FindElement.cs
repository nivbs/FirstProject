using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Linq;
using OpenQA.Selenium.Support.UI;

namespace Infrastructure.Utils
{
    public static class FindElement
    {
        public static DriverUser WaitUntilNotExist(IWebElement webElement, DriverUser driverUser)
        {
            DefaultWait<IWebElement> defaultWait = new DefaultWait<IWebElement>(webElement);
            defaultWait.Timeout = TimeSpan.FromSeconds(20);
            return defaultWait.Until<DriverUser>(myWebElement =>
            {
                try
                {
                    if (myWebElement.Enabled)
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

        public static T WaitUntilClickRefreshed<T>(Button button,
            KeyValuePair<ISearchContext, string> keyValuePair = new KeyValuePair<ISearchContext, string>())
            where T : DriverUser
        {
            DefaultWait<Button> defaultWait = new DefaultWait<Button>(button);
            defaultWait.Timeout = TimeSpan.FromSeconds(20);
            defaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException),
                typeof(NoSuchElementException), typeof(ElementNotInteractableException));
            T driverUser = button.Click<T>(keyValuePair);
            
            return defaultWait.Until<T>(myButton =>
            {
                if (myButton.IsEnabled())
                {
                    return driverUser;
                }
                
                return null;
            });
        }


        public static T WaitUntilClickChangeId<T>(Button button,
            KeyValuePair<ISearchContext, string> keyValuePair = new KeyValuePair<ISearchContext, string>())
            where T : DriverUser
        {
            string buttonToString = button.ToString();
            T driverUser = button.Click<T>(keyValuePair);
            DefaultWait<Button> defaultWait = new DefaultWait<Button>(button);
            defaultWait.Timeout = TimeSpan.FromSeconds(20);
            //defaultWait.Until<IWebElement>(ExpectedConditions
            //    .InvisibilityOfElementLocated(By.CssSelector($"[href='{button.GetLink()}']")));
            
            return driverUser;

            //return defaultWait.Until<T>(myButton =>
            //{
            //    try
            //    {
            //        if (myButton.ToString() != buttonToString)
            //        {
            //            return driverUser;
            //        }

            //        return null;
            //    }
            //    catch (StaleElementReferenceException)
            //    {
            //        return driverUser;
            //    }
            //    catch (NoSuchElementException)
            //    {
            //        return driverUser;
            //    }
            //});
        }
    }
}
