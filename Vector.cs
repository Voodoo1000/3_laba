using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_laba
{
    public class Vector
    {
        private double x;
        private double y;
        private double z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public string Verbose()
        {
            return String.Format("({0}, {1}, {2})", this.x, this.y, this.z);

        }

        public static Vector operator +(Vector a, Vector b)
        {
            double newX = a.x + b.x;
            double newY = a.y + b.y;
            double newZ = a.z + b.z;
            return new Vector(newX, newY, newZ);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            double newX = a.x - b.x;
            double newY = a.y - b.y;
            double newZ = a.z - b.z;
            return new Vector(newX, newY, newZ);
        }

        public static double Length(Vector a)
        {
            return Math.Round(Math.Sqrt(Math.Pow(a.x, 2) + Math.Pow(a.y, 2) + Math.Pow(a.z, 2)), 4);
        }

        public static double ScalarProd(Vector a, Vector b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }

        public static String VectorProd(Vector a, Vector b)
        {
            double firstPart = a.y * b.z - a.z * b.y;
            double secondPart = a.z * b.x - a.x * b.z;
            double thirdPart = a.x * b.y - a.y * b.x;
            return String.Format("{0}*i + {1}*j + {2}*k", firstPart, secondPart, thirdPart);
        }
    }
}
