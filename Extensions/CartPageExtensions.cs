using System.Linq;
using Infrastructure.Pages;
using Infrastructure.Components;

namespace Extensions
{
    public static class CartPageExtensions
    {
        public static ProductRow GetFirstProductRow(this CartPage cartPage)
            => cartPage.CartTable.ProductRows.FirstOrDefault();
    }
}
