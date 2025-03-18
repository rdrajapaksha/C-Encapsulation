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
        public static double radius;
        public static void Main(string[] args)
        {
            // taken a user input for the radius

            Console.WriteLine("Enter the radius: ");
            radius = double.Parse(Console.ReadLine());

            // pass it to the EncapData class
            EncapData data1 = new EncapData();
            // data1.radius = radius; // data1.radius is a private data member
            data1.Radius = radius;

            Console.WriteLine("AREA: " + data1.Area);
            Console.WriteLine("Circumference: " + data1.circum);


            Console.ReadLine();
        }
    }

}