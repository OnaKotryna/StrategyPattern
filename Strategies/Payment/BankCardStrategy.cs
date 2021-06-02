using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategies.Payment
{
    class BankCardStrategy : IPaymentStrategy
    {
        public double calculateTaxes(double price)
        {
            double taxedPrice = price + price * 0.4;
            return taxedPrice;
        }
    }
}
