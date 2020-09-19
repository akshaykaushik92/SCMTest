using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCMTestPromotionEngine;
using SCMTestPromotionEngine.Models;
using System;
using System.Collections.Generic;

namespace SCMTestPromotionUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ScenarioA()
        {
            BusniessLogic busniessLogic = new BusniessLogic();
            CheckoutQuantities checkoutQuantities = new CheckoutQuantities
            {
                QuantitySkuA = 1, QuantitySkuB = 1, QuantitySkuC = 1, QuantitySkuD = 0
            };
            double testResult = busniessLogic.CalculateTotal(checkoutQuantities);
            Assert.AreEqual(100, testResult);
        }

        [TestMethod]
        public void ScenarioB()
        {
            BusniessLogic busniessLogic = new BusniessLogic();
            CheckoutQuantities checkoutQuantities = new CheckoutQuantities
            {
                QuantitySkuA = 5, QuantitySkuB = 5, QuantitySkuC = 1, QuantitySkuD = 0
            };
            double testResult = busniessLogic.CalculateTotal(checkoutQuantities);
            Assert.AreEqual(370, testResult);
        }

        [TestMethod]
        public void ScenarioC()
        {
            BusniessLogic busniessLogic = new BusniessLogic();
            CheckoutQuantities checkoutQuantities = new CheckoutQuantities
            {
                QuantitySkuA = 3, QuantitySkuB = 5, QuantitySkuC = 1, QuantitySkuD = 1
            };
            double testResult = busniessLogic.CalculateTotal(checkoutQuantities);
            Assert.AreEqual(280, testResult);
        }
    }
}
