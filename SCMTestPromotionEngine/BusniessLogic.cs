using SCMTestPromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCMTestPromotionEngine
{
    public class BusniessLogic
    {
        public double CalculateTotal(CheckoutQuantities checkoutQuantities)
        {
            var priceSkuA = CalculateSkuAPrice(checkoutQuantities);
            var priceSkuB = CalculateSkuBPrice(checkoutQuantities);
            var priceSkuC = CalculateSkuCPrice(checkoutQuantities);
            var priceSkuD = CalculateSkuDPrice(checkoutQuantities);
            return priceSkuA + priceSkuB + priceSkuC + priceSkuD;
        }

        private double CalculateSkuAPrice(CheckoutQuantities cartQuantity)
        {
            return 0;
        }

        private double CalculateSkuBPrice(CheckoutQuantities cartQuantity)
        {
            return 0;
        }

        private double CalculateSkuCPrice(CheckoutQuantities cartQuantity)
        {
            return 0;
        }

        private double CalculateSkuDPrice(CheckoutQuantities cartQuantity)
        {
            return 0;
        }
    }
}
