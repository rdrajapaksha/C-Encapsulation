using Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lec04Recap
{
    public class Program
    {
        static void Main(string[] args)
        {
            //taken a user input for the radius
            Console.WriteLine("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            //pass it to the EncapData class
            EncapData data1 = new EncapData();
            //data1.Radius = radius;//data1.Radius is a private data member
            data1.Radius = radius;

        }
    }

}