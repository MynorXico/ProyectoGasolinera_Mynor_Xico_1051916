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
        Formato objFormato = new Formato();
      
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
                objFormato.mensajeError("Por favor ingrese un número válido");
                Console.ResetColor();
                return false;
            }
            return true;
        }
        public bool esNumeroDouble(string num)
        {
            try
            {
                double.Parse(num);
                Console.ResetColor();
            }
            catch
            {
                objFormato.mensajeError("Por favor ingrese un número válido");
                Console.ResetColor();
                return false;
            }
            return true;
        }
        public bool esPositivo(double num)
        {
            if (num > 0)
            {
                Console.ResetColor();
                return true;
            }
            Console.ResetColor();
            return false;
        }
    }
}
