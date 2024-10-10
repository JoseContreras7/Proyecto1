using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CircleWrapper
    {
        private Circle circle;

        // constructor wrapper
        public CircleWrapper(double radius)
        {
            circle = new Circle(); //Intance of circle
            SetRadius(radius);  //set radio 
        }

        // Using reflection to set the new value
        private void SetRadius(double radius)
        {
            var radiusField = typeof(Circle).GetField("radius", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            if (radiusField != null)
            {
                radiusField.SetValue(circle, radius);
            }
        }

        //circumference 
        public double CalculateCircumference()
        {
            return circle.Calculate(r => 2 * Math.PI * r);
        }
    }
}
