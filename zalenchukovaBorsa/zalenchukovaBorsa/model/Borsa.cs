using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zalenchukovaBorsa.model
{
    internal class Borsa
    {
        private double kgzelen;
        private double kgplod;
        private int totalkgzelen;
        private int totalkgplod;

        private double Kgzelen
        {
            get { return kgzelen; }
            set { this.kgzelen = value; }
        }
        private double Kgplod
        {
            get { return kgplod; }
            set { this.kgplod = value; }
        }
        private double Totalkgzelen
        {
            get { return totalkgzelen; }
            set { this.totalkgzelen = value; }
        }
        private double Totalkgplod
        {
            get { return totalkgplod; }
            set { this.totalkgplod = value; }
        }


    }
}
