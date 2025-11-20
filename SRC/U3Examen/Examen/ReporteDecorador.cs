using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{

    public abstract class ReporteDecorador : IReporte
    {
        protected IReporte _reporteEnvuelto;
        public ReporteDecorador(IReporte reporte)
        {
            _reporteEnvuelto = reporte;
        }

        public virtual string Generar()
        {
            return _reporteEnvuelto.Generar();
        }
    }
}
