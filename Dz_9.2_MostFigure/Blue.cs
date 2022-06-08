using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_9._2_MostFigure
{
    class Blue: Color
    {
        public Blue(IFigure figure) : base(figure)
        {
        }

        public override string Operation()
        {
            return "Синий " + base._figure.OperationImplementation();
        }
    }
}
