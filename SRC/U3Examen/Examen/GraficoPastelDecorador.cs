using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class GraficoPastelDecorador : ReporteDecorador
    {
        public GraficoPastelDecorador(IReporte reporte) : base(reporte)
        {
        }
        public override string Generar()
        {
            return base.Generar() + "\n + [Gráfico de Pastel] Añadido";
        }
    }
}
