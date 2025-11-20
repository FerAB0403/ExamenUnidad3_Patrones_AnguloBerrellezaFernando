using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class FormatoTextoDecorador : ReporteDecorador
    {
        private string _fuente;
        private string _color;
        public FormatoTextoDecorador(IReporte reporte, string fuente, string color) : base(reporte)
        {
            _fuente = fuente;
            _color = color;
        }
        public override string Generar()
        {
            return base.Generar() + $"\n + [Formato: Fuente={_fuente}, Color={_color}] aplicado";
        }
    }
}
