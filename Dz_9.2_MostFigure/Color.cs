using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_9._2_MostFigure
{
    class Color
    {
        protected IFigure _figure;

        public Color(IFigure figure)
        {
            this._figure = figure;
        }

        public virtual string Operation()
        {
            return "Пустой цвет " + _figure.OperationImplementation();
        }
    }
}
