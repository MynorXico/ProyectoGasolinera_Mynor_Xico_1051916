using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Mynor_Xico_1051916
{
    /*
        Proyecto que simula un sistema para llevar el control y contabilidad de una gasollinera.
    */
    class Program
    {
        static void Main(string[] args)
        {
            // Constantes de dimensiones
            const int anchoPorDefecto = 150;
            const int altoPorDefecto = 300;


            // Definir Propiedades de la Consola
            Console.Title = "GASTROL - Mynor Xico";
            try {
                System.Console.WindowWidth = anchoPorDefecto;
                System.Console.WindowHeight = altoPorDefecto;
                System.Console.SetWindowPosition(-50, -50);
            }
            catch{
                Console.WriteLine("Ocurrió un error ajustando las dimensiones de la ventana de la consola.");
            }

            // Instanciación de objeto Menú Principal
            MenuPrincipal objMenuPrincipal = new MenuPrincipal();

            // Muestra el menú principal al usuario
            objMenuPrincipal.pantallaPrincipal();


        }
    }
}
