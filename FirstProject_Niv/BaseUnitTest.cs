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
    public class BaseUnitTest
    {
        public HomePage HomePage { get; set; }
        public ChromeDriver Driver { get; private set; }

        [TestInitialize]
        public void Intitalize()
        {
            Driver = new ChromeDriver(@"C:\Users\niv\Desktop");
            Driver.Url = @"http://automationpractice.com/index.php";
            HomePage = new HomePage(Driver);
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.Close();
        }

        [TestMethod]
        public void Test1()
        {
            HomePage.Cart.MyShippingClick().CartTable.Should().NotBeNull();
        }
    }
}
