using System;

namespace AICore.Utilities
{
    public static class MathUtil
    {
        public static double Sigmoid(double x)
        {
            return 1.0 / (1.0 + Math.Exp(-x));
        }
    }

}