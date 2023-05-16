using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.FigureInterfaces
{
    public interface ITriangle : IShape
    {
        double FirstSide { get; }
        double SecondSide { get; }
        double ThirdSide { get; }

        bool IsRectangular { get; }
    }
}
