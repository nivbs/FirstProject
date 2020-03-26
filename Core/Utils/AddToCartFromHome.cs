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
    }
}
