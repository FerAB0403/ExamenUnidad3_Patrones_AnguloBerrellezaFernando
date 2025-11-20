using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public abstract class ComponenteExportar
    {
        public string Nombre { get; set; }
        public ComponenteExportar(string nombre)
        {
            Nombre = nombre;
        }
        public abstract void MostrarJerarquia(int nivel);
    }
}
