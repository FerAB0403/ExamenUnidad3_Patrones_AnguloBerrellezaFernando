using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class CategoriaExportar : ComponenteExportar
    {
        private List<ComponenteExportar> _hijos = new List<ComponenteExportar>();
        public CategoriaExportar(string nombre) : base(nombre) { }
        public void Agregar(ComponenteExportar componente)
        {
            _hijos.Add(componente);
        }
        public void Quitar(ComponenteExportar componente)
        {
            _hijos.Remove(componente);
        }
        public override void MostrarJerarquia(int nivel)
        {
            Console.WriteLine(new string ('+', nivel) + " " + Nombre);
            
            foreach (var hijo in _hijos)
            {
                hijo.MostrarJerarquia(nivel + 1);
            }
        }
    }
}
