using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public struct Coords
    {
        public Coords(double x, double y)
        {
            x = x;
            y = y;
        }
        public double x { get; }
        public double y { get; }


        public override string ToString() => $"({x},{y})";









    }
}
