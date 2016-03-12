using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Mynor_Xico_1051916
{
    /*
        Clase que se encarga de controlar los errores de tipos de datos
    */
    class Validador
    {
        // Instanciación de objeto Formato
        Formato objFormato = new Formato();
        /// <summary>
        /// Función que devuelve verdadero si la cadena ingresada puede ser convertida a número entero.
        /// </summary>
        /// <param name="num">Número que se desea corroborar</param>
        /// <returns>Verdadero o Falso</returns>
        public bool esNumeroEntero(string num)
        {
            try
            {
                int.Parse(num);
                Console.ResetColor();
            }
            catch
            {
                Console.ResetColor();
                objFormato.mensajeError(" ***ERROR*** Debe ingresar un número entero.");
                objFormato.mensajeError("Por favor ingrese un número válido");
                Console.ResetColor();
                return false;
            }
            return true;
        }
        /// <summary>
        /// Función que devuelve verdadero si la cadena ingresada puede ser convertida a número real.
        /// </summary>
        /// <param name="num"´>Cadena de texto que se comprobará si puede ser convertida</param>
        /// <returns>Verdadero o falso</returns>
        public bool esNumeroDouble(string num)
        {
            try
            {
                double.Parse(num);
                Console.ResetColor();
            }
            catch
            {
                objFormato.mensajeError(" ***ERROR*** Debe ingresar un número real");
                objFormato.mensajeError("Por favor ingrese un número válido");
                Console.ResetColor();
                return false;
            }
            return true;
        }
        /// <summary>
        /// Función que develve verdadero si el número ingresado es mayor a cero
        /// </summary>
        /// <param name="num">Número que se desea comprobar</param>
        /// <returns>Verdadero o Falso</returns>
        public bool esPositivo(double num)
        {
            if (num > 0)
            {
                Console.ResetColor();
                return true;
            }
            Console.ResetColor();
            objFormato.mensajeError(" ***ERROR*** Debe ingresar un número positivo");
            return false;
        }
    }
}
