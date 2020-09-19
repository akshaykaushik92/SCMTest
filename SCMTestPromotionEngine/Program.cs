using SCMTestPromotionEngine.Models;
using System;

namespace SCMTestPromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckoutQuantities quantities = new CheckoutQuantities();
            Console.WriteLine("Please enter you quantity for the below SKU's");

            Console.WriteLine("Enter quantity for SKU A");
            quantities.QuantitySkuA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter quantity for SKU B");
            quantities.QuantitySkuB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter quantity for SKU C");
            quantities.QuantitySkuC = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter quantity for SKU D");
            quantities.QuantitySkuD = int.Parse(Console.ReadLine());

            BusniessLogic busniessLogic = new BusniessLogic();
            double total = busniessLogic.CalculateTotal(quantities);

            Console.WriteLine("The total amount is " + total);
        }
    }
}
