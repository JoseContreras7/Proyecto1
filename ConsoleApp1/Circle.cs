using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public sealed class Circle
    {
        private double radius;
        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }
}
