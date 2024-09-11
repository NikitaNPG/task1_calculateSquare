using NUnit.Framework;
using task1_calculateSquare;
using System;

namespace task1_calculateSquare_test
{
    public class task1_calculateSquare_test
    {
        [TestFixture]
        public class GeometryLibraryTests
        {
            [Test]
            public void CircleArea_Test()
            {
                double radius = 5;
                var circle = new Circle(radius);

                double area = circle.GetArea();

                Assert.Equals(Math.PI * Math.Pow(radius, 2), area);
            }

            [Test]
            public void TriangleArea_Test()
            {
                double a = 3, b = 4, c = 5;
                var triangle = new Triangle(a, b, c);

                double area = triangle.GetArea();

                Assert.Equals(6, area);
            }

            [Test]
            public void ShapeCalculator_Test()
            {
                IShape circle = new Circle(5);
                IShape triangle = new Triangle(3, 4, 5);

                double circleArea = ShapeCalculator.CalculateArea(circle);
                double triangleArea = ShapeCalculator.CalculateArea(triangle);

                Assert.Equals(Math.PI * Math.Pow(5, 2), circleArea);
                Assert.Equals(6, triangleArea);
            }
        }
    }
}
