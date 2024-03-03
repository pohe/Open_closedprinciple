using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_closedprinciple
{
    public class OCP3NotCorrect
    {
        public class GoodsShipping
        {
            // Method to calculate shipping cost for road transport
            public double CalculateRoadShippingCost(double weight)
            {
                return weight * 0.1; // Assume cost is $0.1 per kg for road transport
            }

            // Method to calculate shipping cost for air transport
            public double CalculateAirShippingCost(double weight)
            {
                return weight * 1.5; // Assume cost is $1.5 per kg for air transport
            }
        }

        public static void Run()
        {
            GoodsShipping goodsShipping = new GoodsShipping();

            double weight = 100; // Assume weight of goods is 100 kg

            // Calculate shipping cost for road transport
            double roadShippingCost = goodsShipping.CalculateRoadShippingCost(weight);
            Console.WriteLine($"Shipping cost for road transport: ${roadShippingCost}");

            // Calculate shipping cost for air transport
            double airShippingCost = goodsShipping.CalculateAirShippingCost(weight);
            Console.WriteLine($"Shipping cost for air transport: ${airShippingCost}");
        }
    }
}
