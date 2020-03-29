using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infrastructure;
using OpenQA.Selenium;
using System.Threading.Tasks;
using FluentAssertions;

namespace FirstProject_Niv
{
    [TestClass]
    public class ClickingInCatalogTests : BaseCatalogTests
    {
        [TestMethod]
        public void AddToCartSuccess()
        {
            string firstProductName = WomenCatalogPage.Products.First().BottomBlock.ProductName;

            WomenCatalogPage.Products.First()
                .BottomBlock.ItemButtonsContainer
                .AddToCartClick()
                .ContinueShoppingClickInCatalog()
                .Cart.Products.Any(product => product.ProductInfo.GetProductName() == firstProductName)
                .Should()
                .BeTrue();
        }

        [TestMethod]
        public void TestGetXPath()
        {
            string xPath = WomenCatalogPage.Products.First().BottomBlock.GetMyXPath();
        }

        [TestMethod]
        public void ClickOnColorOfProductSuccess()
        {
            ColorButton firstColorButton = WomenCatalogPage.Products.First()
                                            .BottomBlock
                                            .ColorsButtons.ToList()[0];

            firstColorButton
                .GetColorStyle()
                .Should()
                .Be(firstColorButton
                .ColorClick()
                .ProductInfo
                .GetSelectedColorStyle());
        }
    }
}
