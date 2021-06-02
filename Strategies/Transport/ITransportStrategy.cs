using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface ITransportStrategy
    {
        public double calculateDuration(double distance);
        public double calculateDistance(double distance);
        public double calculatePrice(double price, double distance);

    }
}
