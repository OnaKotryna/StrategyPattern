using StrategyPattern.Strategies.Payment;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Trip
    {
        private ITransportStrategy transportStrategy;
        private IPaymentStrategy paymentStrategy;

        private double duration;
        private double distance;
        private double price;
        private double totalPrice;

        // Transporto strategija
        public Trip(ITransportStrategy strategy, double distance = 10, double price = 30)
        {
            transportStrategy = strategy;
            this.distance = distance;
            this.price = price;
        }
        // Mokejimo budo strategija
        public Trip(IPaymentStrategy strategy, double distance = 10, double price = 30)
        {
            paymentStrategy = strategy;
            this.distance = distance;
            this.price = price;
        }
        // Transporto ir mokejimo budo strategijos
        public Trip(ITransportStrategy tStrategy, IPaymentStrategy pStrategy, double distance = 10, double price = 30)
        {
            transportStrategy = tStrategy;
            paymentStrategy = pStrategy;
            this.distance = distance;
            this.price = price;
        }
        // Metodai, kurie naudoja strategijas
        public double Duration() {
            duration = transportStrategy.calculateDuration(distance);
            return duration;
        }

        public double Distance() {
            distance = transportStrategy.calculateDistance(distance);
            return distance;
        }

        public double Price() {
            price = transportStrategy.calculatePrice(price, distance);
            return price;
        }

        public double TotalPrice()
        {
            totalPrice = paymentStrategy.calculateTaxes(price);
            return totalPrice;
        }
    }
}
