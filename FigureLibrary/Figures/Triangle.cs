using FigureLibrary.FigureInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Figures
{
    public class Triangle : ITriangle
    {
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            IsRectangular = (FirstSide * FirstSide) + (SecondSide * SecondSide) == ThirdSide * ThirdSide 
                            || (SecondSide * SecondSide) + (ThirdSide * ThirdSide) == FirstSide * FirstSide 
                            || (ThirdSide * ThirdSide) + (FirstSide * FirstSide) == SecondSide * SecondSide;
        }

        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }
        public bool IsRectangular { get; }

    public double CalcShapeArea()
        {
            double semiperimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - FirstSide) * (semiperimeter - SecondSide) * (semiperimeter - ThirdSide));
        }
    }
}
