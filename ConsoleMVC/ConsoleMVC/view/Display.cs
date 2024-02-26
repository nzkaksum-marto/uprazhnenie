﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.view
{
    public class Display
    {
        public double Percent { get; set; }
        public double Amount { get; set; }
        public double Total { get; set; }
        public double TipAmount { get; set; }
        public Display() 
        {
            Percent = 0;
            Amount = 0;
            Total = 0;  
            TipAmount = 0;
            GetValues();
        }
        private void GetValues()
        {
            Console.WriteLine("Enter the amount of the meal:");
            Amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the percent you want to tip: ");
            Percent = double.Parse(Console.ReadLine());
        }
        public void ShowTipandTotal()
        {
            Console.WriteLine("Your total tip is {0:C}", TipAmount);
            Console.WriteLine("Your totalwillbe {0:C}", Total);
        }

    }
}