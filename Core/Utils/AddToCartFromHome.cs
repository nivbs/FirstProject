using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Utils
{
    public static class AddToCartFromHome
    {
        public static ProductPane FirstProduct(HomePage homePage)
            => homePage.Products.First()
                .BottomBlock.ItemButtonsContainer
                .AddToCartClick();

        public static ProductPane LastProduct(HomePage homePage)
            => homePage.Products.Last()
                .BottomBlock.ItemButtonsContainer
                .AddToCartClick();

        public static ProductPane ProductByIndex(HomePage homePage, int index)
        {
            if (index >= 0 && index < homePage.Products.Count())
            {
                return homePage.Products.ToList()[index]
                      .BottomBlock.ItemButtonsContainer
                      .AddToCartClick();
            }

            return FirstProduct(homePage);
        }
    }
}
