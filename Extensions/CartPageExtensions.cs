using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure;
using System.Linq;

namespace Extensions
{
    public static class CartPageExtensions
    {
        public static ProductRow GetFirstProductRow(this CartPage cartPage)
            => cartPage.CartTable.ProductRows.First();
    }
}
