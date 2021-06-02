using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Entities
{
    public class Order
    {
        private ITransportStrategy transportStrategy;

        private double distance;
        private double duration;
        private double price;
        private double orderPrice;

        public Order(ITransportStrategy strategy, double distance = 10, double orderPrice = 10)
        {
            transportStrategy = strategy;
            this.distance = distance;
            this.orderPrice = orderPrice;
        }

        public double Distance()
        {
            distance = transportStrategy.calculateDistance(distance);
            return distance;
        }

        public double Duration()
        {
            duration = transportStrategy.calculateDuration(distance);
            return duration;
        }

        public double TotalPrice()
        {
            price = transportStrategy.calculatePrice(orderPrice, distance);
            return price;
        }
    }
}
