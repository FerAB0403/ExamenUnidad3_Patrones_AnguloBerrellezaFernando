using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Bienvenido al Gestor de Reportes ---");

            Console.WriteLine("\nDecorar el Reporte");

            IReporte miReporte = new ReporteBase();

            bool seguirDecorando = true;
            while (seguirDecorando)
            {
                Console.WriteLine("\n¿Añadir funcionalidad al reporte?");
                Console.WriteLine("1. Gráfico de Barras");
                Console.WriteLine("2. Gráfico de Pastel");
                Console.WriteLine("3. Cambiar Formato de Texto");
                Console.WriteLine("0. Terminar de decorar");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        miReporte = new GraficoBarrasDecorador(miReporte);
                        Console.WriteLine(" > Gráfico de barras añadido.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        miReporte = new GraficoPastelDecorador(miReporte);
                        Console.WriteLine(" > Gráfico de pastel añadido.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Write("  Ingrese nombre de la fuente (ej. Arial): ");
                        string fuente = Console.ReadLine();
                        Console.Write("  Ingrese color del texto (ej. Azul): ");
                        string color = Console.ReadLine();

                        miReporte = new FormatoTextoDecorador(miReporte, fuente, color);
                        Console.WriteLine(" > Formato de texto aplicado.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "0":
                        seguirDecorando = false;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }

            Console.WriteLine("\n--- Vista Previa del Reporte Final ---");
            Console.WriteLine(miReporte.Generar());
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("\nExportar el Reporte (Jerarquía)");
            Console.WriteLine("Construyendo árbol de formatos de exportación.");

            var raizExportar = new CategoriaExportar("Todos los Formatos");

            var categoriaDocumento = new CategoriaExportar("Documento");
            var categoriaImagen = new CategoriaExportar("Imagen");

            raizExportar.Agregar(categoriaDocumento);
            raizExportar.Agregar(categoriaImagen);


            categoriaDocumento.Agregar(new FormatoExportar("PDF"));
            categoriaDocumento.Agregar(new FormatoExportar("Excel"));
            categoriaDocumento.Agregar(new FormatoExportar("Word"));
            categoriaDocumento.Agregar(new FormatoExportar("PowerPoint"));

            categoriaImagen.Agregar(new FormatoExportar("JPG"));
            categoriaImagen.Agregar(new FormatoExportar("PNG"));


            Console.WriteLine("\n--- Jerarquía de Exportación Disponible ---");
            raizExportar.MostrarJerarquia(0);

            Console.WriteLine("\nSeleccionar Formato de Exportación");
            Console.Write("Escriba el formato en el que desea exportar (ej. PDF, JPG, Word): ");
            string formatoElegido = Console.ReadLine();
            Console.ReadKey();
            Console.Clear();

            if (!string.IsNullOrWhiteSpace(formatoElegido))
            {
                Console.WriteLine($"\n--- EXPORTANDO REPORTE A {formatoElegido.ToUpper()} ---");
                Console.WriteLine(miReporte.Generar());
                Console.WriteLine($"--- REPORTE GUARDADO COMO report.{formatoElegido.ToLower()} ---");
            }
            else
            {
                Console.WriteLine("No se seleccionó ningún formato. Exportación cancelada.");
            }

            Console.WriteLine("\nPresione Enter para salir.");
            Console.ReadLine();
        }
    }
}
