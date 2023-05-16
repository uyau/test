using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.FigureInterfaces
{
    public interface ICircle : IShape
    {
        double Radius { get; }
    }
}
