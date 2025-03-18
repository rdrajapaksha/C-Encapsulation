using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class EncapData
    {
        private double radius;
        //private double pi = 3.147;
        private double pi = Math.PI;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double getRadius()
        {
            return radius;
        }

        public double circum
        {
            get { return radius * pi * 2; }
        }

        public double Area
        {
            get { return pi * radius * radius; }
        }
    }
}
        