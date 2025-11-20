using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class FormatoExportar : ComponenteExportar
    {
        public FormatoExportar(string nombre) : base(nombre) { }
        public override void MostrarJerarquia(int nivel)
        {
            Console.WriteLine(new string('-', nivel) + " " + Nombre);
        }
    }
}
