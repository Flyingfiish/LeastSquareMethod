using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastSquareMethod
{
    public class LSM
    {
        private double[] xValues;
        private double[] yValues;
        private double sumOfX;
        private double sumOfY;
        private double sumOfMultiply;
        private double sumOfSquareX;
        private int n { get { return xValues.Length; } }

        public LSM(double[] x, double[] y)
        {
            xValues = x;
            yValues = y;
            sumOfX = xValues.Sum();
            sumOfY = yValues.Sum();
            sumOfMultiply = getMultiplySum();
            sumOfSquareX = getSquareXSum();
        }

        private double getMultiplySum()
        {
            double result = 0;
            for (var i = 0; i < xValues.Length; i++)
                result += xValues[i] * yValues[i];
            return result;
        }

        private double getSquareXSum()
        {
            double result = 0;
            for (var i = 0; i < xValues.Length; i++)
                result += xValues[i] * xValues[i];
            return result;
        }

        public (double, double) GetParameters()
        {
            var a = (n * sumOfMultiply - sumOfX * sumOfY) / (n * sumOfSquareX - sumOfX * sumOfX);
            var b = (sumOfY - a * sumOfX) / n;
            return (a, b);
        }
        
    }
}
