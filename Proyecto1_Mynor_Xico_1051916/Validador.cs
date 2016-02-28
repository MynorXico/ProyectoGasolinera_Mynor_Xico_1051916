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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Por favor ingrese un número válido");
                System.Threading.Thread.Sleep(1200);
                Console.Clear();
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
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Número inválido");
                System.Threading.Thread.Sleep(1200);
                return false;
            }
            return true;
        }
        public bool esPositivo(double num)
        {
            if (num > 0)
            {
                return true;
            }
            return false;
        }
    }
}
