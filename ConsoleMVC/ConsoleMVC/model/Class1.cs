using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.model
{
    internal class Class1
    {
        private double amount;
        private double percent;

        public double Amount
        {
            get { return amount; }
            set { this.amount = value; }
        }
        public double Percent
        {
            get { return percent; }
            set
            {
                if (value > 1)
                {
                    this.percent = value / 100.0;

                }
                else
                {
                    this.percent = value;
                }
            }
        }
        public Class1(double amount, double percent)
        {
            Amount = amount;
            Percent = percent;
        }
        public Class1() : this(0,0) { }

        public double CalculateTip()
        {
            return this.Percent * this.Amount;
        }
        public double CalculateTotal() 
        { 
            return CalculateTip() * this.Amount;
        }
    }
}
