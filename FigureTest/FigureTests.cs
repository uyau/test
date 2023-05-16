using FigureLibrary.FigureInterfaces;
using FigureLibrary.Figures;

namespace FigureTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2, 2, 3, ExpectedResult = 1.984313483298443)]
        public double TriangleAreaTest(double firstSide, double secondSide, double thirdSide)
        {
            IShape triangle = new Triangle(firstSide, secondSide, thirdSide);
            return triangle.CalcShapeArea();
        }

        [Test]
        [TestCase(4, 5, 3, ExpectedResult = true)]
        public bool TriangleIsRectangularTest(double first, double second, double third)
        {
            var triangle = new Triangle(first, second, third);
            return triangle.IsRectangular;
        }

        [Test]
        [TestCase(123.12, ExpectedResult = 47621.940310228165)]
        public double CircleAreaTest(double radius)
        {
            IShape cirle = new Circle(radius);
            return cirle.CalcShapeArea();
        }
    }
}