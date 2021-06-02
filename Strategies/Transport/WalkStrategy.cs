using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategies.Transport
{
    class WalkStrategy : ITransportStrategy
    {
        public double calculateDistance(double distance)
        {
            double calculatedDistance = distance * 0.5;
            return calculatedDistance;
        }

        public double calculateDuration(double distance)
        {
            double calculatedDuration = distance * 1.5;
            return calculatedDuration;
        }

        public double calculatePrice(double price, double distance)
        {
            double transportPrice = price;
            return transportPrice;
        }
    }
}
