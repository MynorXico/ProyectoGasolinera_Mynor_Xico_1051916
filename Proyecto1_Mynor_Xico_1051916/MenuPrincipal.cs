using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Mynor_Xico_1051916
{
    /// <summary>
    /// Menú que se mostrará al usuario
    /// </summary>
    class MenuPrincipal
    {
        // Declaración de variables
        string strOpcionMenu;
        bool bolSalir = false;

        // Instanciación de menús secundarios
        MenuSecundario objMenu2 = new MenuSecundario("", "Si", "No");
        MenuSecundario objMenu3 = new MenuSecundario("", "Ingresar Combustible", "Definir Precios de Combustible", "Vender Combustible", "Mostrar Información de Ventas", "Salir");

        // Instanciación de clase en la que se ejecutan las instrucciones para la interacción con el usaurio
        Procesos objProcesos = new Procesos();

        // Instanciación de clase Formato
        Formato objFormato = new Formato();

        // Instanciación de clase Validador
        Validador objValidador = new Validador();

        VentasAutomáticas ventas = new VentasAutomáticas();

        /// <summary>
        /// Constructor de la clase MenuPrincipal sin atributos
        /// </summary>
        public MenuPrincipal()
        {
        }
        
        /// <summary>
        /// Método que escribe el menu Pantalla Principal
        /// </summary>
        public void escribirMenu()
        {
            pantallaPrincipal();
        }

        /// <summary>
        /// Método que inicia la interacción con el Usuario
        /// </summary>
        public void pantallaPrincipal()
        {
            EscribirBienvenida();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ResetColor();
            Console.ReadKey(false);
            Console.Clear();

            do
            {
                EscribirBienvenida();
                objMenu3.EscribirMenuSecundario5();
                strOpcionMenu = Console.ReadLine();
                Console.ResetColor();

                switch (strOpcionMenu)
                {
                    case "1":
                        Console.Clear();
                        objProcesos.solicitarCombustible();
                        break;
                    case "2":
                        Console.Clear();
                        objProcesos.definirPrecios();
                        break;
                    case "3":
                        Console.Clear();
                        objProcesos.venderGasolina();
                        break;
                    case "4":
                        Console.Clear();
                        objProcesos.mostrarInformacionVentas();
                        break;
                    case "5":
                        Console.Clear();
                        objFormato.escribirContenido("Gracias por utilizar nuestros servicios");
                        System.Threading.Thread.Sleep(900);
                        objFormato.escribirContenido("Esperamos haberle servido de la mejor manera");
                        System.Threading.Thread.Sleep(900);
                        objFormato.mensajeExito("Finaliza Programa...");
                        bolSalir = true;
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (!bolSalir);

            /*
            // Abre menú para agregar combustible
            objProcesos.solicitarCombustible();
            Console.Clear();
            // Abre menú para la definición de nuevos precios
            objProcesos.definirPrecios();
            Console.Clear();
            // Abre menú para la venta de Gasolina
            objProcesos.venderGasolina();
            Console.Clear();
            // Muestra la información de ventas
            objProcesos.mostrarInformacionVentas();
            Console.ReadLine();


            // Mensaje de Despedida
            objFormato.escribirContenido("Gracias por utilizar nuestros servicios");
            System.Threading.Thread.Sleep(900);
            objFormato.mensajeExito("Finaliza Programa");
            */

        }
        static void EscribirBienvenida()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("     █▀▄ ▀ █▀▀ █▄░█ ▐▌░▐▌ █▀▀ █▄░█ ▀ █▀▄ ▄▀▄     ▄▀▄     ▄▀▀░ ▄▀▄ ▄▀▀ ▀█▀ █▀▀▄ ▄▀▄ █░░");
            Console.WriteLine("     █▀█ █ █▀▀ █░▀█ ░▀▄▀░ █▀▀ █░▀█ █ █░█ █░█     █▀█     █░▀▌ █▀█ ░▀▄ ░█░ █▐█▀ █░█ █░▄");
            Console.WriteLine("     ▀▀░ ▀ ▀▀▀ ▀░░▀ ░░▀░░ ▀▀▀ ▀░░▀ ▀ ▀▀░ ░▀░     ▀░▀     ▀▀▀░ ▀░▀ ▀▀░ ░▀░ ▀░▀▀ ░▀░ ▀▀▀");
            Console.ResetColor();
        }
        
    }
}
