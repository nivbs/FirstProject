using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstProject_Niv
{
    [TestClass]
    public class FilterInCatalogTests : BaseCatalogTests
    {
        [TestMethod]
        public void FilterByColorSuccess()
        {
            //string color = WomenCatalogPage.FilterRow.ColorStyles().First();

            //WomenCatalogPage.FilterRow
            //    .ColorClick(color)
            //    .Products
            //    .All(product => product.BottomBlock.ColorsButtons
            //    .Any(colorButton => colorButton.GetColorStyle() == color))
            //    .Should()
            //    .BeTrue();
        }
    }
}
