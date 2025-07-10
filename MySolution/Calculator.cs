namespace Tools
{
    public class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Sub(double x, double y)
        {
            return x - y;
        }

        public static double Mul(double x, double y)
        {
            return x * y;
        }

        public static double Div(double x, double y)
        {
            if (y < 0)
            {
                double ErrorMessage = double.PositiveInfinity;
                return ErrorMessage;
            }
            else
            {
                return x / y;
            }
        }
    }
}
