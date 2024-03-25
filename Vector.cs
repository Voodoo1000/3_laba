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
        public double x;
        public double y;
        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public string Verbose()
        {
            return String.Format("({0}, {1})", this.x, this.y);

        }

        public static Vector operator +(Vector a, Vector b)
        {
            double newX = a.x + b.x;
            double newY = a.y + b.y;
            return new Vector(newX, newY);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            double newX = a.x - b.x;
            double newY = a.y - b.y;
            return new Vector(newX, newY);
        }

        public static Vector operator *(Vector a, double number)
        {
            return new Vector(a.x * number, a.y * number);
        }
        public static Vector operator /(Vector a, double number)
        {
            return new Vector(a.x / number, a.y / number);
        }
    }
}
