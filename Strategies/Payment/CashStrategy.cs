using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategies.Payment
{
    class CashStrategy : IPaymentStrategy
    {
        public double calculateTaxes(double price)
        {
            double taxedPrice = price + price * 0.21;
            return taxedPrice;
        }
    }
}
