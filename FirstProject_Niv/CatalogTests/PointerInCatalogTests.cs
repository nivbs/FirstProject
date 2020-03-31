using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions.Internal;
using System.Drawing;
using java.awt;
using OpenQA.Selenium.Interactions;
using FluentAssertions;

namespace FirstProject_Niv
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
