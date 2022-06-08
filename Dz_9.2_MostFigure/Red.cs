using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_9._2_MostFigure
{
    class Red: Color
    {
        public Red(IFigure figure) : base(figure)
        {
        }

        public override string Operation()
        {
            return "Красный " + base._figure.OperationImplementation();
        }
    }
}
