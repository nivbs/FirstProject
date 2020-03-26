using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using FluentAssertions;
using Extensions;
using OpenQA.Selenium;


namespace FirstProject_Niv
{
    [TestClass]
    public class CartTests : BaseUnitTest
    {
        protected CartPage CartPage { get; set; }

        [TestInitialize]
        public override void Initialize()
        {
            base.Initialize();

            CartPage = HomePage.Products.First()
                .BottomBlock.ItemButtonsContainer
                .AddToCartClick()
                .ContinueShoppingClickInHome()
                .Products.Last()
                .BottomBlock.ItemButtonsContainer
                .AddToCartClick()
                .ProceedToCheckoutClick();
        }

        [TestMethod]
        public void RemoveProductSuccess()
        {
            string itemName = CartPage.GetFirstProductRow().ProductDescription.ProductNameButton.GetText();
            int countOfProducts = CartPage.CartTable.ProductRows.Count();

            CartPage = CartPage
                .GetFirstProductRow()
                .DeleteClick();
            
            CartPage
                .CartTable
                .ProductRows
                .ToList()
                .ForEach(productRow =>
                            productRow
                            .ProductDescription.ProductNameButton
                            .GetText()
                            .Should()
                            .NotBe(itemName));

            CartPage
                .CartTable
                .ProductRows
                .Count()
                .Should()
                .Be((countOfProducts - 1));
        }

        [TestMethod]
        public void AddQuantityOfProductSuccess()
        {
            CartPage
                .GetFirstProductRow().Quantity
                .PlusClick()
                .GetFirstProductRow()
                .TotalPrice
                .Should()
                .Be(2.0 * CartPage.GetFirstProductRow().UnitPrice);
        }

        [TestMethod]
        public void ChangeToDecimalQuantityFail()
        {
            double totalFirstProductPrice = CartPage.GetFirstProductRow().TotalPrice;
            
            CartPage
                .GetFirstProductRow().Quantity
                .QuantityTextBox
                .FillNewValue("1.5");

            CartPage
                .GetFirstProductRow()
                .TotalPrice
                .Should()
                .Be(totalFirstProductPrice);
        }

        [TestMethod]
        public void ClickPlusOnDecimalQuantitySuccess()
        {
            CartPage
                .GetFirstProductRow().Quantity
                .QuantityTextBox
                .FillNewValue("1.5");

            CartPage
                .GetFirstProductRow().Quantity
                .PlusClick()
                .GetFirstProductRow()
                .TotalPrice
                .Should()
                .Be(2.0 * CartPage.GetFirstProductRow().UnitPrice);
        }
    }
}
