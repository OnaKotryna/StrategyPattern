using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace StrategyPattern.Strategies.Transport
{
    class CarStrategy : ITransportStrategy
    {
        public double calculateDistance(double distance)
        {
            double calculatedDistance = distance * 1.5;
            return calculatedDistance;
        }

        public double calculateDuration(double distance)
        {
            double calculatedDuration = distance * 0.5;
            return calculatedDuration;
        }

        public double calculatePrice(double price, double distance)
        {
            double transportPrice = price + distance * 1.5;
            return transportPrice;
        }
    }
}
