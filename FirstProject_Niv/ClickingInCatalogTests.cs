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
        public void ClickOnColorOfProductSuccess()
        {
            string color = WomenCatalogPage.Products.First().BottomBlock.ColorsButtons.First().GetText();

            WomenCatalogPage.Products.First()
                .BottomBlock.ColorsButtons.First().Click<ProductPage>();
        }
    }
}
