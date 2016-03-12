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
            //AnimaciónBienvenida();
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
                        objFormato.mensajeError("***ERROR * **Opción no válida");
                        break;
                }
                Console.Clear();
            } while (!bolSalir);
        }

        /// <summary>
        /// Método que muestra una animación de bienvenida
        /// </summary>
        static void AnimaciónBienvenida()
        {
            for (int i = 4; i >= 0; i--)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("          █▀▄ ▀ █▀▀ █▄░█ ▐▌░▐▌ █▀▀ █▄░█ ▀ █▀▄ ▄▀▄     ▄▀▄     ▄▀▀░ ▄▀▄ ▄▀▀ ▀█▀ █▀▀▄ ▄▀▄ █░░");
                Console.WriteLine("          █▀█ █ █▀▀ █░▀█ ░▀▄▀░ █▀▀ █░▀█ █ █░█ █░█     █▀█     █░▀▌ █▀█ ░▀▄ ░█░ █▐█▀ █░█ █░▄");
                Console.WriteLine("          ▀▀░ ▀ ▀▀▀ ▀░░▀ ░░▀░░ ▀▀▀ ▀░░▀ ▀ ▀▀░ ░▀░     ▀░▀     ▀▀▀░ ▀░▀ ▀▀░ ░▀░ ▀░▀▀ ░▀░ ▀▀▀");
                Console.ResetColor();
                System.Threading.Thread.Sleep(300);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("     █▀▄ ▀ █▀▀ █▄░█ ▐▌░▐▌ █▀▀ █▄░█ ▀ █▀▄ ▄▀▄     ▄▀▄     ▄▀▀░ ▄▀▄ ▄▀▀ ▀█▀ █▀▀▄ ▄▀▄ █░░");
                Console.WriteLine("     █▀█ █ █▀▀ █░▀█ ░▀▄▀░ █▀▀ █░▀█ █ █░█ █░█     █▀█     █░▀▌ █▀█ ░▀▄ ░█░ █▐█▀ █░█ █░▄");
                Console.WriteLine("     ▀▀░ ▀ ▀▀▀ ▀░░▀ ░░▀░░ ▀▀▀ ▀░░▀ ▀ ▀▀░ ░▀░     ▀░▀     ▀▀▀░ ▀░▀ ▀▀░ ░▀░ ▀░▀▀ ░▀░ ▀▀▀");
                Console.ResetColor();
                System.Threading.Thread.Sleep(300);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("  █▀▄ ▀ █▀▀ █▄░█ ▐▌░▐▌ █▀▀ █▄░█ ▀ █▀▄ ▄▀▄     ▄▀▄     ▄▀▀░ ▄▀▄ ▄▀▀ ▀█▀ █▀▀▄ ▄▀▄ █░░");
                Console.WriteLine("  █▀█ █ █▀▀ █░▀█ ░▀▄▀░ █▀▀ █░▀█ █ █░█ █░█     █▀█     █░▀▌ █▀█ ░▀▄ ░█░ █▐█▀ █░█ █░▄");
                Console.WriteLine("  ▀▀░ ▀ ▀▀▀ ▀░░▀ ░░▀░░ ▀▀▀ ▀░░▀ ▀ ▀▀░ ░▀░     ▀░▀     ▀▀▀░ ▀░▀ ▀▀░ ░▀░ ▀░▀▀ ░▀░ ▀▀▀");
                Console.ResetColor();
                System.Threading.Thread.Sleep(300);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("     █▀▄ ▀ █▀▀ █▄░█ ▐▌░▐▌ █▀▀ █▄░█ ▀ █▀▄ ▄▀▄     ▄▀▄     ▄▀▀░ ▄▀▄ ▄▀▀ ▀█▀ █▀▀▄ ▄▀▄ █░░");
                Console.WriteLine("     █▀█ █ █▀▀ █░▀█ ░▀▄▀░ █▀▀ █░▀█ █ █░█ █░█     █▀█     █░▀▌ █▀█ ░▀▄ ░█░ █▐█▀ █░█ █░▄");
                Console.WriteLine("     ▀▀░ ▀ ▀▀▀ ▀░░▀ ░░▀░░ ▀▀▀ ▀░░▀ ▀ ▀▀░ ░▀░     ▀░▀     ▀▀▀░ ▀░▀ ▀▀░ ░▀░ ▀░▀▀ ░▀░ ▀▀▀");
                Console.ResetColor();
                switch (i)
                {
                    case 4:
                        Console.WriteLine("********************");
                        break;
                    case 3:
                        Console.WriteLine("*****************************************");
                        break;
                    case 2:
                        Console.WriteLine("************************************************************"); ;
                        break;
                    case 1:
                        Console.WriteLine("*******************************************************************************");
                        break;
                    case 0:
                        Console.WriteLine("******************************************************************************************");
                        break;
                }
                System.Threading.Thread.Sleep(300);
            }
        }
        /// <summary>
        /// Método que escribe "BIENVENIDO A GASTROL"
        /// </summary>
        static void EscribirBienvenida()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("     █▀▄ ▀ █▀▀ █▄░█ ▐▌░▐▌ █▀▀ █▄░█ ▀ █▀▄ ▄▀▄     ▄▀▄     ▄▀▀░ ▄▀▄ ▄▀▀ ▀█▀ █▀▀▄ ▄▀▄ █░░");
            Console.WriteLine("     █▀█ █ █▀▀ █░▀█ ░▀▄▀░ █▀▀ █░▀█ █ █░█ █░█     █▀█     █░▀▌ █▀█ ░▀▄ ░█░ █▐█▀ █░█ █░▄");
            Console.WriteLine("     ▀▀░ ▀ ▀▀▀ ▀░░▀ ░░▀░░ ▀▀▀ ▀░░▀ ▀ ▀▀░ ░▀░     ▀░▀     ▀▀▀░ ▀░▀ ▀▀░ ░▀░ ▀░▀▀ ░▀░ ▀▀▀");
            Console.ResetColor();
        }   
    }
}
