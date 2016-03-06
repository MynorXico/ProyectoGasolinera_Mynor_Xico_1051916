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
        // Instanciación de menús secundarios
        MenuSecundario objMenu1 = new MenuSecundario("Tipo de Gasolina", "Diesel", "Regular", "Super", "Salir");
        MenuSecundario objMenu2 = new MenuSecundario("", "Si", "No");


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
            bool opcionValida = false;
            do
            {// Solicita al usuario si desea o no ingresar gasaolina a los depósitos
                Console.Clear();
                objFormato.escribirTitulo("Cantidad de gasolina en los depósitos");
                objProcesos.MostrarCombustible();
                objFormato.pregunta("¿Desea ingresar combustible a los depósitos?");
                objMenu2.EscribirMenuSecundario2ST();
                string strOpcion = Console.ReadLine();
                // En caso de ingresar una opción no válida, solicita nuevamente al usuario el ingreso de una.
                while (!objValidador.esNumeroEntero(strOpcion))
                {
                    Console.Beep();
                    Console.Clear();
                    objFormato.escribirTitulo("Cantidad de gasolina en los depósitos");
                    objProcesos.MostrarCombustible();
                    objFormato.pregunta("¿Desea ingresar combustible a los depósitos?");
                    objMenu2.EscribirMenuSecundario2ST();
                    strOpcion = Console.ReadLine();
                }

                // Realiza la conversión una vez seguro de que la opción ingresada puese ser convertida a un entero
                int intOpcion = Convert.ToInt32(strOpcion);
                if (intOpcion == 1)
                {
                    opcionValida = true;
                    Console.Clear();
                    objProcesos.solicitarCombustible();
                }
                if (intOpcion == 1 || intOpcion == 2)
                {
                    opcionValida = true;
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
                }
                else
                {
                    objFormato.mensajeError("Escriba una opción válida");
                }
            } while (!opcionValida);
            // Mensaje de Despedida
            objFormato.escribirContenido("Gracias por utilizar nuestros servicios");
            System.Threading.Thread.Sleep(900);
            objFormato.mensajeExito("Finaliza Programa");


        }

        
    }
}
