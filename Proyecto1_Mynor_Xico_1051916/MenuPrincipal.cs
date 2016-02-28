using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Mynor_Xico_1051916
{
    class MenuPrincipal
    {
        // Instanciación de menús secundarios
        MenuSecundario objMenu1 = new MenuSecundario("Tipo de Gasolina", "Diesel", "Regular", "Super", "Salir");
        MenuSecundario objMenu2 = new MenuSecundario("", "Si", "No");
        MenuSecundario objMenu3 = new MenuSecundario("a","B","C","D", "D");
        MenuSecundario objMenu4 = new MenuSecundario("a","b","c","d", "D");

        Gasolinera objGasolinera = new Gasolinera();

        // Instanciación de clase Formato
        Formato objFormato = new Formato();

        // Instanciación de clase Validador
        Validador objValidador = new Validador();

        // Constructor de clase Menu Principal
        public MenuPrincipal()
        {
        }
        
        public void escribirMenu()
        {
            pantallaPrincipal();
        }

        public void pantallaPrincipal()
        {
            objFormato.escribirTitulo("Cantidad de gasolina en los depósitos");
            objGasolinera.MostrarCombustible();
            objFormato.pregunta("¿Desea ingresar combustible a los depósitos?");
            objMenu2.EscribirMenuSecundario2ST();
            string strOpcion = Console.ReadLine();

            while (!objValidador.esNumeroEntero(strOpcion))
            {
                Console.Clear();
                objFormato.escribirTitulo("Cantidad de gasolina en los depósitos");
                objGasolinera.MostrarCombustible();
                objFormato.pregunta("¿Desea ingresar combustible a los depósitos?");
                objMenu2.EscribirMenuSecundario2ST();
                strOpcion = Console.ReadLine();
            }

            int intOpcion = Convert.ToInt32(strOpcion);
            if(intOpcion == 1)
            {
                Console.Clear();
                objGasolinera.solicitarCombustible();
            }
            if(intOpcion == 1 || intOpcion == 2)
            {
                Console.Clear();
                objGasolinera.definirPrecios();
                Console.Clear();
            }

            objFormato.escribirContenido("Gracias por utilizar nuestros servicios");
            System.Threading.Thread.Sleep(900);
            objFormato.mensajeExito("Finaliza Programa");

        }

    }
}
