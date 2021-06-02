using StrategyPattern.Entities;
using StrategyPattern.Strategies.Payment;
using StrategyPattern.Strategies.Transport;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pradine situacija:");
            Trip carTrip = new Trip(new CarStrategy());
            Console.WriteLine("Trip By Car:\nDistance: " + carTrip.Distance() + "\nDuration: " + carTrip.Duration() + "\nPrice: " + carTrip.Price() + "\n");
            
            Trip bicycleTrip = new Trip(new BicycleStrategy());
            Console.WriteLine("Trip By Bicycle:\nDistance: " + bicycleTrip.Distance() + "\nDuration: " + bicycleTrip.Duration() + "\nPrice: " + bicycleTrip.Price() + "\n");

            Trip walkTrip = new Trip(new WalkStrategy());
            Console.WriteLine("Trip By Walking:\nDistance: " + walkTrip.Distance() + "\nDuration: " + walkTrip.Duration() + "\nPrice: " + walkTrip.Price() + "\n");

            Console.WriteLine("Reikalavimas A:");
            Order carOrder = new Order(new CarStrategy());
            Console.WriteLine("Order Delivered By Car:\nDistance: " + carOrder.Distance() + "\nDuration: " + carOrder.Duration() + "\nPrice: " + carOrder.TotalPrice() + "\n");
            
            Console.WriteLine("Reikalavimas B:");
            Trip walkTripBank = new Trip(new WalkStrategy(), new BankCardStrategy());
            Console.WriteLine("Trip By Walking paid by Bank Card:\nPrice: "+ walkTripBank.Price()+ "\nTotal Price:" + walkTripBank.TotalPrice());
            
        }
    }
}
