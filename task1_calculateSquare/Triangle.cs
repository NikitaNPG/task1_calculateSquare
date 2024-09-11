namespace task1_calculateSquare
{
    public class Triangle : IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Стороны должны быть положительными числами");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Сумма любых двух сторон должна быть больше третьей");

            A = a;
            B = b;
            C = c;
        }

        public double GetArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRightTriangle()
        {
            double a2 = Math.Pow(A, 2);
            double b2 = Math.Pow(B, 2);
            double c2 = Math.Pow(C, 2);

            if(A > B && A > C) {
                return a2 == Math.Sqrt(b2 + c2);
            }
            else if (B > C && B > A) {
                return b2 == Math.Sqrt(a2 + c2);
            }
            else if (C > B && C > A) {
                return c2 == Math.Sqrt(a2 + b2);
            }

            return false;
        }
    }
}
