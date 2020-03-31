using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using FluentAssertions;
using Infrastructure.Common;

namespace Tests
{
    [TestClass]
    public class PointerInCatalogTests : BaseCatalogTests
    {
        [TestMethod]
        public void PointerOnProductSuccess()
        {
            bool isDisplayed = WomenCatalogPage.Products.First()
                .BottomBlock
                .ItemButtonsContainer
                .IsDisplayed();

            var point = WomenCatalogPage.Products.First().GetLocation();
            Actions action = new Actions(Driver);
            action.MoveToElement(Driver.FindElement(By.CssSelector(CssSelectorsInDriver.TopBlock))).Perform();
            WomenCatalogPage.Products.First()
                .BottomBlock
                .ItemButtonsContainer
                .IsDisplayed()
                .Should()
                .BeTrue();
            
            string answer = isDisplayed.ToString();
        }
    }
}
