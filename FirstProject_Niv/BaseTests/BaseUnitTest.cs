using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Chrome;
using Infrastructure.Pages;

namespace Tests
{
    [TestClass]
    public abstract class BaseUnitTest
    {
        protected HomePage HomePage { get; set; }
        protected ChromeDriver Driver { get; private set; }

        [TestInitialize]
        public virtual void Initialize()
        {
            Driver = new ChromeDriver(@"C:\Users\niv\Desktop");
            Driver.Navigate().GoToUrl(@"http://automationpractice.com/index.php");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Driver.Manage().Window.Maximize();

            HomePage = new HomePage(Driver);
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
