using System;

namespace Tahzoo.FitnesseFixtures.Fixtures.Slim
{
    /// <summary>
    /// Demo class for a script table
    /// </summary>
    public class BasicMathTest
    {
        private double _result;

        // getter method (without prefix) ("check")
        public double Result()
        {
            return _result;
        }

        // getter method ("ensure"/"reject")
        public bool IsPositiveResult()
        {
            return _result > 0.0;
        }

        // action method
        public void AddIntegers(int p1, int p2)
        {
            _result = p1 + p2;
        }

        // action method
        public void Pythagoras(double p1, double p2)
        {
            _result = Math.Sqrt(p1 * p1 + p2 * p2);
        }
    }
}
