using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public static class CssSelectorsInDriver
    {
        
        public static string BottomBlock => $"{Product} .right-block";
        public static string Cart => ".shopping_cart";
        public static string CartTable => ".row #center_column";
        public static string ColorButton => ".color_pick";
        public static string FilterRow => "#left_column";
        public static string Product => ".product_list .ajax_block_product";
        public static string ProductButtons => ".button-container";
        //public static string ProductDescription => $"{ProductRow} .cart_description";
        public static string ProductInCart => ".products dt";
        public static string ProductInfoInCart => ".cart-info";
        public static string ProductInfoInProductPage => "#center_column .primary_block";
        public static string ProductPane => "#layer_cart .clearfix";
        public static string ProductRow => "tbody tr";
        public static string Quantity => $"{ProductRow} .cart_quantity";
        public static string TopBlock => $"{Product} .left-block";
        public static string TopMenuBlock => "#block_top_menu";
        public static string ViewedProductInfo => $"{ViewedProducts} .products-block li";
        public static string ViewedProducts => "#viewed-products_block_left";

        public static Dictionary<string, string> CatalogPage => new Dictionary<string, string>
        {
            {"FilterRow", FilterRow },
            {"ViewedProductInfo", ViewedProductInfo },
            {"ViewedProducts", ViewedProducts },
            { "BottomBlock",BottomBlock },
            {"TopBlock", TopBlock },
            {"Product", Product },
            {"ProductBottuns", ProductButtons },
            {"ColorButton", ColorButton },
            {"ProductPane", ProductPane },
            {"ProductInCart", ProductInCart },
            {"ProductInfoInCart", ProductInfoInCart },
            {"TopMenuBlock", TopMenuBlock },
            {"Cart", Cart }
        };
        public static Dictionary<string, string> HomePage => new Dictionary<string, string>
        {
            { "BottomBlock",BottomBlock },
            {"Product", Product },
            {"TopBlock", TopBlock },
            {"ProductBottuns", ProductButtons },
            {"ProductPane", ProductPane },
            {"ProductInCart", ProductInCart },
            {"ProductInfoInCart", ProductInfoInCart },
            {"TopMenuBlock", TopMenuBlock },
            {"Cart", Cart }
        };
        public static Dictionary<string, string> ProductPage => new Dictionary<string, string>
        {
            {"ColorButton", ColorButton },
            {"ProductInCart", ProductInCart },
            {"ProductInfoInCart", ProductInfoInCart },
            {"TopMenuBlock", TopMenuBlock },
            {"Cart", Cart }
        };
        public static Dictionary<string, string> CartPage => new Dictionary<string, string>
        {
            {"CartTable" , CartTable},
            {"ProductRow", ProductRow },
            {"Quantity", Quantity },
            {"ProductInCart", ProductInCart },
            {"ProductInfoInCart", ProductInfoInCart },
            {"TopMenuBlock", TopMenuBlock },
            {"Cart", Cart }
        };
    }
}
