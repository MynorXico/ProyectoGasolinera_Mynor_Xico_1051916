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
            // Cambia el título de la consola
            Console.Title = "GASONTROL - Mynor Xico";

            // Instanciación de objeto Menú Principal
            MenuPrincipal objMenuPrincipal = new MenuPrincipal();

            // Muestra el menú principal al usuario
            objMenuPrincipal.escribirMenu();


        }
    }
}
