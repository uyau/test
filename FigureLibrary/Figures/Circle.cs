using FigureLibrary.FigureInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Figures
{
    public class Circle : ICircle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; }

        public double CalcShapeArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
