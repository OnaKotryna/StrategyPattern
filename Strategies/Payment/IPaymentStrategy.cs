using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategies.Payment
{
    public interface IPaymentStrategy
    {
        public double calculateTaxes(double price);
    }
}
