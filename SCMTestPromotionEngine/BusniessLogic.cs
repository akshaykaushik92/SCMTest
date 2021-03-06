﻿using Microsoft.Extensions.Logging;
using SCMTestPromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SCMTestPromotionEngine
{
    public class BusniessLogic
    {
        private readonly ILogger<BusniessLogic> _logger;

        public double CalculateTotal(CheckoutQuantities checkoutQuantities)
        {
            try
            {
                if (checkoutQuantities != null)
                {
                    var priceSkuA = CalculateSkuAPrice(checkoutQuantities);
                    var priceSkuB = CalculateSkuBPrice(checkoutQuantities);
                    var priceSkuC = CalculateSkuCPrice(checkoutQuantities);
                    var priceSkuD = CalculateSkuDPrice(checkoutQuantities);
                    return priceSkuA + priceSkuB + priceSkuC + priceSkuD;
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error occured in CalculateTotal", ex);
                throw ex;
            }         
        }

        private double CalculateSkuAPrice(CheckoutQuantities cartQuantity)
        {
            try
            {
                double priceOfA = 0;
                DataAccessLayer dataAccessLayer = new DataAccessLayer();
                var applicablePromotionIds = dataAccessLayer.GetPromotionId("A");
                foreach (var item in applicablePromotionIds)
                {
                    switch (item.PromotionTypeName)
                    {
                        case "PromotionType1":
                            priceOfA = CalculatePromotionType1("A", cartQuantity.QuantitySkuA);
                            break;
                    }
                }
                return priceOfA;
            }
            catch(Exception ex)
            {
                _logger.LogError("Error occured in CalculateSkuAPrice", ex);
                throw ex;
            }
        }

        private double CalculateSkuBPrice(CheckoutQuantities cartQuantity)
        {
            try
            {
                double priceOfB = 0;
                DataAccessLayer dataAccessLayer = new DataAccessLayer();
                var applicablePromotionIds = dataAccessLayer.GetPromotionId("B");
                foreach (var item in applicablePromotionIds)
                {
                    switch (item.PromotionTypeName)
                    {
                        case "PromotionType1":
                            priceOfB = CalculatePromotionType1("B", cartQuantity.QuantitySkuB);
                            break;
                    }
                }
                return priceOfB;
            }
            catch(Exception ex)
            {
                _logger.LogError("Error occured in CalculateSkuBPrice", ex);
                throw ex;
            }
        }

        private double CalculateSkuCPrice(CheckoutQuantities cartQuantity)
        {
            try
            {
                double priceOfC = 0;
                DataAccessLayer dataAccessLayer = new DataAccessLayer();
                var applicablePromotionIds = dataAccessLayer.GetPromotionId("C");
                foreach (var item in applicablePromotionIds)
                {
                    switch (item.PromotionTypeName)
                    {
                        case "PromotionType2":
                            priceOfC = CalculatePromotionType2("C", cartQuantity);
                            break;
                    }
                }
                return priceOfC;
            }
            catch(Exception ex)
            {
                _logger.LogError("Error occured in CalculateSkuCPrice", ex);
                throw ex;
            }
        }

        private double CalculateSkuDPrice(CheckoutQuantities cartQuantity)
        {
            try
            {
                double priceOfD = 0;
                DataAccessLayer dataAccessLayer = new DataAccessLayer();
                var applicablePromotionIds = dataAccessLayer.GetPromotionId("D");
                foreach (var item in applicablePromotionIds)
                {
                    switch (item.PromotionTypeName)
                    {
                        case "PromotionType2":
                            priceOfD = CalculatePromotionType2("D", cartQuantity);
                            break;
                    }
                }
                return priceOfD;
            }
            catch(Exception ex)
            {
                _logger.LogError("Error occured in CalculateSkuDPrice", ex);
                throw ex;
            }
        }

        private double CalculatePromotionType1(string sku, int quantity)
        {
            try
            {
                double price = 0;
                DataAccessLayer dataAccessLayer = new DataAccessLayer();
                var pricing = dataAccessLayer.GetPricing();
                var promotionType1 = dataAccessLayer.GetPromotionType1();

                var promotion = promotionType1.Where(x => x.SkuName == sku).FirstOrDefault();
                var actualPricing = pricing.Where(x => x.SkuName == sku).FirstOrDefault();
                price = (quantity / promotion.SkuMultiple) * promotion.PromotionPricing + (quantity % promotion.SkuMultiple) * actualPricing.Price;

                return price;
            }
            catch(Exception ex)
            {
                _logger.LogError("Error occured in CalculatePromotionType1", ex);
                throw ex;
            }
        }

        private double CalculatePromotionType2(string sku, CheckoutQuantities cartQuantity)
        {
            try
            {
                double price = 0;
                int promotionQuantity = 0;
                DataAccessLayer dataAccessLayer = new DataAccessLayer();
                var pricing = dataAccessLayer.GetPricing();
                var promotionType2 = dataAccessLayer.GetPromotionType2();

                var promotion = promotionType2.Where(x => x.SkuName == sku).FirstOrDefault();
                var actualPricing = pricing.Where(x => x.SkuName == sku).FirstOrDefault();

                if (sku == "C")
                {
                    if (cartQuantity.QuantitySkuD <= cartQuantity.QuantitySkuC)
                    {
                        promotionQuantity = cartQuantity.QuantitySkuC - (cartQuantity.QuantitySkuC - cartQuantity.QuantitySkuD);
                        cartQuantity.QuantitySkuC = cartQuantity.QuantitySkuC - promotionQuantity;
                        cartQuantity.QuantitySkuD = cartQuantity.QuantitySkuD - promotionQuantity;
                    }
                    else
                    {
                        promotionQuantity = cartQuantity.QuantitySkuD - (cartQuantity.QuantitySkuD - cartQuantity.QuantitySkuC);
                        cartQuantity.QuantitySkuD = cartQuantity.QuantitySkuD - promotionQuantity;
                        cartQuantity.QuantitySkuC = 0;
                    }

                    price = promotionQuantity * promotion.PromotionPricing + cartQuantity.QuantitySkuC * actualPricing.Price;

                }

                else if (sku == "D")
                    price = cartQuantity.QuantitySkuD * actualPricing.Price;

                return price;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error Occured in CaluculatePromotionType2", ex);
                throw ex;
            }
        }
    }
}
