using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using OpenQA.Selenium.Chrome;
using FluentAssertions;

namespace FirstProject_Niv
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
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            HomePage = new HomePage(Driver);
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
