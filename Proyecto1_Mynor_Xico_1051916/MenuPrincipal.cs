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
            objFormato.mensajeBienvenida("    ***Bienvenido a GASTROL***");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
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


        }

        
    }
}
