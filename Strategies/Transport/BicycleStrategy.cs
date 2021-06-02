using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategies.Transport
{
    class BicycleStrategy : ITransportStrategy
    {
        public double calculateDistance(double distance)
        {
            double calculatedDistance = distance * 0.75;
            return calculatedDistance;
        }

        public double calculateDuration(double distance)
        {
            double calculatedDuration = distance * 0.75;
            return calculatedDuration;
        }

        public double calculatePrice(double price, double distance)
        {
            double transportPrice = price + distance * 1.2;
            return transportPrice;
        }
    }
}
