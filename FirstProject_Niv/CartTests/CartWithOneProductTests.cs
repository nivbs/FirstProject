using Extensions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assertions;
using Infrastructure.Components;
using Infrastructure.Pages;

namespace Tests
{
    [TestClass]
    public class CartWithOneProductTests : BaseCartTest
    {
        [TestInitialize]
        public override void Initialize()
        {
            base.Initialize();

            CartPage = ProductPane.ProceedToCheckoutClick();
        }

        [TestMethod]
        public void AddQuantityOfProductSuccess()
        {
            CartPage
                .GetFirstProductRow().Quantity
                .PlusClick()
                .GetFirstProductRow()
                .Should()
                .TotalPriceIsTrue();
        }

        [TestMethod]
        public void ChangeToDecimalQuantityFail()
        {
            double totalFirstProductPrice = CartPage.GetFirstProductRow().TotalPrice;

            CartPage
                .GetFirstProductRow().Quantity
                .FillQuantity("1.5");

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
                .FillQuantity("1.5");

            CartPage
                .GetFirstProductRow().Quantity
                .PlusClick()
                .GetFirstProductRow()
                .Should()
                .TotalPriceIsTrue();
        }

        [TestMethod]
        public void ClickMinusOnDecimalQuantitySuccess()
        {
            CartPage
                .GetFirstProductRow().Quantity
                .FillQuantity("2.5");

            CartPage
                .GetFirstProductRow().Quantity
                .MinusClick()
                .GetFirstProductRow()
                .Should()
                .TotalPriceIsTrue();
        }

        [TestMethod]
        public void RemoveProductWhileOneProductInCartSuccess()
        {
            CartPage
                .GetFirstProductRow()
                .DeleteClick()
                .CartTable
                .ProductRows
                .Should()
                .BeNullOrEmpty();
        }
    }
}
