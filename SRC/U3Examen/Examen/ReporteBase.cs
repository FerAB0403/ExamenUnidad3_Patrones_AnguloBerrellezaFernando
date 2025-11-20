using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class ReporteBase : IReporte
    {

        public string Generar()
        {
            return "---REPORTE BASE ---";
        }
    }
}
