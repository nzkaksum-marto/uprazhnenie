﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleMVC.model;
using ConsoleMVC.view;


namespace ConsoleMVC.controller
{
    internal class TipCalculatorController
    {
        private Class1 tip;
        private Display display;
        public TipCalculatorController()
        {
            display = new Display();
            tip = new Class1(display.Amount, display.Percent);
            display.TipAmount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();
            display.ShowTipandTotal();
        }

    }
}
