﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions;
using FluentAssertions;
using Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assertions;

namespace FirstProject_Niv
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
                .Should()
                .TotalPriceIsTrue();
        }

        [TestMethod]
        public void ClickMinusOnDecimalQuantitySuccess()
        {
            CartPage
                .GetFirstProductRow().Quantity
                .QuantityTextBox
                .FillNewValue("2.5");

            CartPage
                .GetFirstProductRow().Quantity
                .MinusClick()
                .GetFirstProductRow()
                .Should()
                .TotalPriceIsTrue();
        }
    }
}